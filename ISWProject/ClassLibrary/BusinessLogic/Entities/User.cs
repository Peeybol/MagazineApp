using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public User()
        {
            MainAuthoredPapers = new List<Paper>();
        }
        public User(string Id, string Name, string Surname, bool alerted, string areasOfInterest, string email, string login, string password):base(Id, Name, Surname)
        {
            MainAuthoredPapers = new List<Paper>();
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Alerted = alerted;
            this.AreasOfInterest = areasOfInterest;
            this.Email = email;
            this.Login = login;
            this.Password = password;
        }
    }
}
