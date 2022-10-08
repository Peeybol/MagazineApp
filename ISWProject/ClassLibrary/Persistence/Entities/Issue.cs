using System;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime? PublicationDate { get; set; }   

        public virtual ICollection<Paper> PublishedPapers { get; set; }

        public virtual Magazine Magazine { get; set; }
    }
}
