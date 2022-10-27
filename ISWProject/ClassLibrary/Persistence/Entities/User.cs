using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Magazine.Entities
{
    public partial class User : Person
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


        // [InverseProperty("Responsible")] // Misma duda que con Person
        public virtual ICollection<Paper> MainAuthoredPapers
        {
            get;
            set;
        }

        public virtual Area Area
        {
            get;
            set;
        }

        public virtual Magazine Magazine
        {
            get;
            set;
        }

    }
}

