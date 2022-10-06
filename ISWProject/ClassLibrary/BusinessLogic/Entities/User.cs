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

        public User(bool alerted, string areasOfInterest, string email, string login, string password) : this()
        {
            Alerted = alerted;
            AreasOfInterest = areasOfInterest;
            Email = email;
            Login = login;
            Password = password;
        }
    }
}
