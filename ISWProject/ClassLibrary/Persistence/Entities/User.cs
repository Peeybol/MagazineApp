using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class User
    {
        public bool Alerted
        {
            set;
            get;
        }

        public string AreasOfInterest
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Login
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }


    }
}
