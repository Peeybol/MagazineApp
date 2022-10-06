using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class User
    {
        public User()
        {

        }

        public User(bool alerted, string areasOfInterest, string email, string login, string password)
        {
            Alerted = alerted;
            AreasOfInterest = areasOfInterest;
            Email = email;
            Login = login;
            Password = password;
        }

        public ICollection<Paper> MainAuthoredPapers
        {
            get;
            set;
        }


    }
}
