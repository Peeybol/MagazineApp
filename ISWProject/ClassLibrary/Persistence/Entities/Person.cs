using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Person
    {

        [Key] 
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname   { get; set; }


        [InverseProperty("CoAuthors")]
        public virtual ICollection<Paper> CoAuthoredPapers
        {
            get;
            set;
        }
    }
}
