using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            Areas = new List<Area>();
            Issues = new List<Issue>();
        }

        public Magazine(string Name, User ChiefEditor):this()
        {
            this.Name = Name;
            this.ChiefEditor = ChiefEditor;
        }

        public Area GetAreaById (int id)
        {
            return this.Areas.FirstOrDefault(a => a.Id == id);
        }

        public void AddArea(Area area)
        {
            this.Areas.Add(area);
        }

        public Area GetAreaByName(string areaName)
        {
            return Areas.FirstOrDefault(a => a.Name == areaName);
        }

        public Paper GetEvPendingPaperById (int id)
        {
            foreach (Area a in Areas)
            {
                Paper paper = a.EvaluationPending.FirstOrDefault(p => p.Id == id);
                if (paper != null) return paper;
            }
            return null;
        }

        public Paper GetPaperById(int id)
        {
            foreach (Area a in Areas)
            {
                Paper paper = a.Papers.FirstOrDefault(p => p.Id == id);
                if (paper != null) return paper;
            }
            return null;
        }

        public Paper GetPublishedPaperById(int id)
        {
            foreach (Issue i in Issues)
            {
                Paper paper = i.PublishedPapers.FirstOrDefault(p => p.Id == id);
                if (paper != null) return paper;
            }
            return null;
        }

        public Paper GetPubPendingPaperById(int id)
        {
            foreach (Area a in Areas)
            {
                Paper paper = a.PublicationPending.FirstOrDefault(p => p.Id == id);
                if (paper != null) return paper;
            }
            return null;
        }

        public Issue GetOpenIssue()
        {
            foreach (Issue i in Issues)
            {
                if (i.PublicationDate == null) return i;
            }
            return null;
        }
        public Issue GetLastIssue()
        {
            return Issues.LastOrDefault();
        }

        public int AddIssue(Issue issue)
        {
            this.Issues.Add(issue);
            return issue.Id;
        } 

        public List<Area> GetAllAreas()
        {
            return this.Areas.ToList<Area>();
        }

        public List<Paper> GetAllPendingPapersInAnArea(string areaName)
        {
            List<Paper> papers = new List<Paper>();
            Area area = GetAreaByName(areaName);
            foreach (Paper paper in area.PublicationPending)
                papers.Add(paper);
            return papers;
        }
    }
}
