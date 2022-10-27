using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Issue
    {
        // [Key]
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime? PublicationDate { get; set; }   

        public virtual ICollection<Paper> PublishedPapers { get; set; }

        [Required] 
        public virtual Magazine Magazine { get; set; }
    }
}
