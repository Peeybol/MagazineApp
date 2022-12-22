using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Services
{
    public class MagazineISWService : IMagazineISWService
    {
        // Dal persistence service 
        private readonly IDAL dal;

        // Resources Manager for error messaging
        private ResourceManager resourceManager;

        // logged in User for verification purposes such as (not complete list):
        // - operations restricted to area editors
        // - operations restricted to chief editor
        // - submitted paper responsible author is logged in user
        private User loggedUser;

        private Entities.Magazine magazine;
        public MagazineISWService(IDAL dal) {
            this.dal = dal;

            // Resource manager for internationalization of error messages is created
            resourceManager = new ResourceManager("ClassLibrary.Resources.ExceptionMessages", Assembly.GetExecutingAssembly());
            // Only one magazine object exists in our system
            // dal.RemoveAllData();
            // DBInitialization();
            magazine = dal.GetAll<Entities.Magazine>().FirstOrDefault();
            if (magazine == null)
            {
                DBInitialization();
            }
        }

        public void Commit()
        {
            dal.Commit();
        }

        public bool IsValidEmail(string email)
        {
            if (email == null || email.Length <= 4) return false;
            int indexAt = email.IndexOf('@');
            int indexDot = email.LastIndexOf('.');
            if (indexAt == -1 || indexDot == -1) return false;
            if (indexAt > indexDot) return false;
            if (indexDot - indexAt <= 2) return false;
            if (email.Length - indexDot < 2) return false;
            return true;
        }

        public bool IsValidPassword(string password)
        {
            if (password == null || password.Length < 8 || password.Length > 32) return false;
            int conds = 0;
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    conds++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    conds++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    conds++;
                    break;
                }
            }
            char[] specialCharacters = { '?', '-', '+', '=', '_', '@', '#', '!', '&', '$' };
            if (password.IndexOfAny(specialCharacters) != -1) conds++;
            if (conds < 4) return false;
            return true;
        }

        public bool IsValidUser(string login)
        {
            if (login == null || login.Length == 0 || login.Length > 30) return false;
            return true;
        }

        private void ValidateLoggedUser(bool validateLogged)
        {
            if (validateLogged) {
                // if user is not logged in and it should be logged in then generate exception
                if (loggedUser == null) throw new ServiceException(resourceManager.GetString("LoggedOutUser"));
            }
            else // if user is logged in and it should not be logged in then generate exception 
                if (loggedUser != null) throw new ServiceException(resourceManager.GetString("LoggedUser"));

        }

        public void DBInitialization()
        {
            // Chief editor registered
            RegisterUser("66666666A", "Javier", "Jaen", false, "HCI, Software Engineering", "fjaen@upv.es", "fjaen", "Manolo123?");

            // Area editors registered
            RegisterUser("77777777B", "Jorge", "Montaner", false, "Software Engineering", "jormonm5@upv.es", "jmontaner", "Manolo123?");
            RegisterUser("88888888C", "Fernando", "Alonso", false, "HCI", "falonso@upv.es", "falonso", "Manolo123?");

            // Author registered
            RegisterUser("99999999D", "Carlos", "Sainz", false, "HCI", "csainz@upv.es", "csainz", "Manolo123?");

            // Magazine created and stored in "magazine" reference
            int magazineId = AddMagazine("University Magazine", "66666666A");
            magazine = dal.GetById<Entities.Magazine>(magazineId);

            // Two Areas added, Login required because only chief editor is allowed to do this 
            Login("fjaen", "Manolo123?");
            AddArea("HCI", "77777777B");
            AddArea("Software Engineering", "88888888C");
            Logout();
        }

        #region User

        public bool CheckAreasExist(string aof)
        {
            string[] areas = aof.Split(',');
            foreach (string area in areas)
            {
                if (magazine != null && magazine.GetAreaByName(area.Trim()) == null) return false;
            }
            return true;
        }

        public void RegisterUser(string id, string name, string surname, bool alerted, string areasOfInterest, string email, string login, string password)
        {
            ValidateLoggedUser(false);
            User u = new User();
            if (id == null || id.Length < 2) throw new ServiceException(resourceManager.GetString("InvalidID"));
            if (dal.GetById<Person>(id) != null && dal.GetById<Person>(id).GetType() == u.GetType()) throw new ServiceException(resourceManager.GetString("LoggedUser"));
            if ((name == null) || (name.Length < 2)) throw new ServiceException(resourceManager.GetString("InvalidUserName"));
            if ((surname == null) || (surname.Length < 2)) throw new ServiceException(resourceManager.GetString("InvalidUserSurname"));
            if (!IsValidEmail(email)) throw new ServiceException(resourceManager.GetString("InvalidEmail"));
            if (!IsValidUser(login) || !CheckUsername(login)) throw new ServiceException(resourceManager.GetString("InvalidUser"));
            if (!IsValidPassword(password)) throw new ServiceException(resourceManager.GetString("InvalidPassword"));
            if (!CheckAreasExist(areasOfInterest)) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));
            Person p = dal.GetById<Person>(id);
            if (p != null)
            {
                dal.Delete<Person>(p);
                Commit();
            }
            User regUser = new Magazine.Entities.User(id, name, surname, alerted, areasOfInterest, email, login, password);
            dal.Insert<User>(regUser);
            Commit();
        }

        public bool CheckUsername(string username)
        {
            return dal.GetWhere<User>(u => u.Login.Equals(username)).FirstOrDefault() == null;
        }

        public string Login(string login, string password)
        {
            ValidateLoggedUser(false);
            if (!IsValidUser(login)) { throw new ServiceException(resourceManager.GetString("InvalidUser")); }
            if (!IsValidPassword(password)) { throw new ServiceException(resourceManager.GetString("InvalidPassword")); }
            User myUser = dal.GetWhere<User>((u) => u.Login.Equals(login)).FirstOrDefault();
            if (myUser == null) { throw new ServiceException(resourceManager.GetString("UserNotExists")); }
            if (!myUser.Password.Equals(password)) { throw new ServiceException(resourceManager.GetString("IncorrectPassword")); }
            loggedUser = myUser;
            return myUser.Id;
        }

        public void Logout() {
            loggedUser = null;
        }

        public User GetCurrentUser()
        {
            return loggedUser;
        }

        #endregion

        #region Paper
        public int SubmitPaper(int areaId, string title, DateTime uploadDate)
        {
            if (title == null || title.Equals("")) { throw new ServiceException(resourceManager.GetString("InvalidTitle")); }
            if (uploadDate == null) { throw new ServiceException(resourceManager.GetString("InvalidUploadDate")); }
            ValidateLoggedUser(true);
            Area area = magazine.GetAreaById(areaId);
            if (area == null) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));
            Paper paper = new Paper(title, uploadDate, area, loggedUser);
            area.Papers.Add(paper);
            area.EvaluationPending.Add(paper);
            paper.EvaluationPendingArea = area;
            paper.BelongingArea = area;
            Commit();
            return paper.Id;
        }

        public Paper GetPaperById(int id)
        {
            return magazine.GetPaperById(id);
        }

        public void RegisterPerson(string id, string name, string surname)
        {
            if (dal.GetById<Person>(id) != null) throw new ServiceException(resourceManager.GetString("LoggedPerson"));
            if ((name == null) || (name.Length < 2)) throw new ServiceException(resourceManager.GetString("InvalidUserName"));
            if ((surname == null) || (surname.Length < 2)) throw new ServiceException(resourceManager.GetString("InvalidUserSurname"));
            Magazine.Entities.Person regPerson = new Magazine.Entities.Person(id, name, surname);
            dal.Insert<Person>(regPerson);
            Commit();
        }
        public Person GetPersonById(string id)
        {
            Person person = dal.GetById<Person>(id);
            if (person != null) return person;
            else throw new ServiceException(resourceManager.GetString("PersonNotExists"));
        }

        public void AddCoauthor(int paperId, string id)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper.CoAuthors.Count() == 4) throw new ServiceException(resourceManager.GetString("MaximumNumberCoauthors"));
            Person person = GetPersonById(id);
            if (person == null) { }
            paper.AddCoauthor(person);
            Commit();
        }

        public void EvaluatePaper(bool accepted, string comments, DateTime date, int paperId)
        {
            ValidateLoggedUser(true);
            if (comments == "") throw new ServiceException(resourceManager.GetString("CommentsNotExist"));
            if (date == null) throw new ServiceException(resourceManager.GetString("InvalidDate"));
            Evaluation evaluation = new Evaluation(accepted, comments, date);
            Paper paper = magazine.GetEvPendingPaperById(paperId);
            if (paper == null) throw new ServiceException(resourceManager.GetString("PaperNotPendingOfEvaluation"));
            if (loggedUser != paper.BelongingArea.Editor) throw new ServiceException(resourceManager.GetString("NotEditor"));
            paper.Evaluation = evaluation;
            paper.BelongingArea.EvaluationPending.Remove(paper);
            paper.EvaluationPendingArea = null;
            if (!accepted)
            {
                paper.BelongingArea.EvaluationPending.Remove(paper);
            }
            else
            {
                paper.PublicationPendingArea = paper.BelongingArea;
                paper.BelongingArea.PublicationPending.Add(paper);
            }
            Commit();
        }

        public bool isAccepted(int paperId)
        {
            Paper myPaper = magazine.GetPaperById(paperId);
            if (myPaper == null) { throw new ServiceException(resourceManager.GetString("PaperNotExists")); }
            else
            {
                if (myPaper.Evaluation == null) { throw new ServiceException(resourceManager.GetString("NotEvaluatedPaper")); }
                else return myPaper.Evaluation.Accepted;
            }

        }

        public bool isEvaluationPending(int paperId)
        {
            if (magazine.GetPaperById(paperId) == null) throw new ServiceException(resourceManager.GetString("PaperNotExists"));
            return magazine.GetEvPendingPaperById(paperId) != null;
        }

        public bool isPublicationPending(int paperId)
        {
            if (magazine.GetPaperById(paperId) == null) throw new ServiceException(resourceManager.GetString("PaperNotExists"));
            return magazine.GetPubPendingPaperById(paperId) != null;
        }


        public void PublishPaper(int paperId)
        {
            if (!loggedUser.Equals(magazine.ChiefEditor)) throw new ServiceException(resourceManager.GetString("NotChiefEditor"));
            Paper paper = GetPaperById(paperId);
            if (paper == null) throw new ServiceException(resourceManager.GetString("PaperNotExists"));
            Issue issue = magazine.GetLastIssue();
            if (issue == null) throw new ServiceException(resourceManager.GetString("IssueNotExists"));
            if (issue.PublishedPapers.Contains(paper)) return;
            issue.PublishedPapers.Add(paper);
            paper.BelongingArea.PublicationPending.Remove(paper);
            paper.Issue = issue;
            Commit();
        }

        public bool IsPublished(int paperId)
        {
            return magazine.GetPublishedPaperById(paperId) != null;
        }

        public List<Paper> ListAllEvaluationPendingPapers()
        {
            List<Paper> PaperList = new List<Paper>();
            foreach (Area a in magazine.Areas)
                foreach (Paper p in a.EvaluationPending)
                    PaperList.Add(p);
            return PaperList;
        }

        public void UnPublishPaper(int paperId)
        {
            if (!loggedUser.Equals(magazine.ChiefEditor)) throw new ServiceException(resourceManager.GetString("NotChiefEditor"));
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null) throw new ServiceException(resourceManager.GetString("PaperNotExists"));
            Issue issue = magazine.GetLastIssue();
            if (issue == null) throw new ServiceException(resourceManager.GetString("IssueNotExists"));
            issue.PublishedPapers.Remove(paper);
            paper.Issue = null;
            paper.BelongingArea.PublicationPending.Add(paper);
            Commit();
        }

        #endregion


        #region Issue
        public int AddIssue(int number)
        {
            if (loggedUser != magazine.ChiefEditor) throw new ServiceException(resourceManager.GetString("NotChiefEditor"));
            Issue issue = new Issue(number, magazine);
            Commit();
            return magazine.AddIssue(issue);
        }

        public List<Area> GetAllAreas()
        {
            return magazine.GetAllAreas();
        }

        public List<string> GetAllAreasNames()
        {
            List<string> names = new List<string>();
            List<Area> areas = magazine.GetAllAreas();
            foreach (Area area in areas)
                names.Add(area.Name);
            return names;
        }

        public List<Paper> GetAllPublicationPendingPapers()
        {
            List<Paper> paperList = new List<Paper>();
            foreach (Area area in magazine.Areas)
                paperList.Concat(area.PublicationPending.ToList<Paper>());

            return paperList;
        }

        public List<Paper> GetAllPublicationPendingPapersInAnArea(string areaName)
        {
            return magazine.GetAllPublicationPendingPapersInAnArea(areaName);
        }

        public List<Paper> GetAllEvaluationPendingPapersInAnArea(string areaName)
        {
            return magazine.GetAllEvaluationPendingPapersInAnArea(areaName);
        }

        public ICollection<Paper> GetAllPublishedPapersInTheLastIssue()
        {
            return magazine.GetLastIssue().PublishedPapers;
        }

        public void BuildAnIssue(DateTime newPublicationDate)
        {
            if (loggedUser != magazine.ChiefEditor) throw new ServiceException(resourceManager.GetString("NotChiefEditor"));
            Issue issue = magazine.GetLastIssue();
            if (issue.PublicationDate != null) throw new ServiceException(resourceManager.GetString("IncorrectDate"));
            if (issue == null) { throw new ServiceException(resourceManager.GetString("IssueNotExists")); }
            if (newPublicationDate.Date < DateTime.Now.Date) throw new ServiceException(resourceManager.GetString("IncorrectDate"));
            issue.PublicationDate = newPublicationDate;
            Commit();
        }

        public int GetLastIssueNumberAndAddANewOne()
        {
            if (!IsChiefEditor(loggedUser)) throw new ServiceException(resourceManager.GetString("NotChiefEditor"));
            Issue myIssue = magazine.GetLastIssue();
            if (myIssue == null)
            {
                AddIssue(1);
                return 1;
            }
            else if (myIssue.PublicationDate != null)
            {
                AddIssue(myIssue.Number + 1);
                return myIssue.Number + 1;

            }
            else return myIssue.Number;
        }

        public Issue GetLastIssue()
        {
             return magazine.Issues.LastOrDefault();
        }

            #endregion

        #region Area


        /// <summary>   Validate area and if correct, add a new area.</summary>
        /// <param>     <c>areaName</c> is the area name. 
        /// </param>     
        /// <param>     <c>editorId</c> is the Id of the area editor. 
        /// </param>
        /// <returns> 
        ///             Area id
        ///             Any required ServiceExceptions
        /// </returns>
        public int AddArea(string areaName, string editorId)
        {
            // validate logged user
            ValidateLoggedUser(true);

            // validate user is chief editor
            if (loggedUser.Magazine == null) throw new ServiceException(resourceManager.GetString("InvalidAddAreaUser"));

            // validate magazine exists
            if (magazine == null) throw new ServiceException(resourceManager.GetString("MagazineNotExists"));

            // validate area name not empty
            if ((areaName == null) || (areaName.Length == 0)) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));

            // validate not another area with same name
            if (magazine.GetAreaByName(areaName) != null) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));

            // validate editor id not empty
            if ((editorId == null) || (editorId.Length == 0)) throw new ServiceException(resourceManager.GetString("NullUserId"));

            // validate editor exists
            var editor = dal.GetById<User>(editorId);
            if (editor == null) throw new ServiceException(resourceManager.GetString("UserNotExists"));

            // inserts area
            Area area = new Area(areaName, editor, magazine);
            magazine.AddArea(area);
            Commit();
            return area.Id;
        }

        public int GetIdByAreaName(string areaName)
        {
            Area area = magazine.GetAreaByName(areaName);
            if (area == null) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));
            else return area.Id;
        }

        #endregion

        #region Magazine

        /// <summary>   Validate data and if correct, add a new magazine with its chief editor.</summary>
        /// <param>     <c>name</c> is the name of the magazine 
        /// </param>
        /// <param>     <c>chiefEditorId</c> is the is the user Id of that becomes chief Editor 
        /// </param>
        /// <returns>   
        ///             Magazine Id
        ///             Any required Service Exceptions 
        /// </returns>
        public int AddMagazine(string name, string chiefEditorId)
        {
            // validate magazine name not empty
            if ((name == null) || (name.Equals(""))) throw new ServiceException(resourceManager.GetString("InvalidMagazineName"));

            // validate chief editor id not empty
            if ((chiefEditorId == null) || (chiefEditorId.Length == 0)) throw new ServiceException(resourceManager.GetString("NullUserId"));

            // validate chief editor exists
            var chief = dal.GetById<User>(chiefEditorId);
            if (chief == null) throw new ServiceException(resourceManager.GetString("UserNotExists"));

            // insert magazine
            Entities.Magazine m = new Entities.Magazine(name, chief);
            dal.Insert(m);
            Commit();
            return m.Id;
        }

        public List<Paper> ListAllPapers()
        {
            if (loggedUser != magazine.ChiefEditor) throw new ServiceException(resourceManager.GetString("NotChiefEditor"));
            List<Paper> list = new List<Paper>();

            foreach (Area a in magazine.Areas)
                foreach (Paper p in a.Papers)
                    list.Add(p);

            return list;
        }

        public List<Paper> ListPapersByArea(Area a)
        {
            return a.Papers.ToList();
        }

        public List<Area> ListAllAreas()
        {
            return magazine.Areas.ToList();
        }

        public List<Person> ListAllPersons()
        {
            return dal.GetAll<Person>().ToList();
        }

        public bool IsAreaEditor(User user, out string area)
        {
            area = "";
            foreach (Area a in magazine.Areas)
            {
                if (a.Editor == user)
                {
                    area = a.Name;
                    return true;
                }
            }
            return false;
        }

        public bool IsChiefEditor(User user)
        {
            return magazine.ChiefEditor == user;
        }
        #endregion
        
    } 
}
