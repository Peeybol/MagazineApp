using System;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue()
        {
            PublishedPapers = new List<Paper>();
        }

        public Issue (int Id, int Number, DateTime PublicationDate, Magazine magazine):this()
        {
            this.Id = Id;
            this.Number = Number;
            this.PublicationDate = PublicationDate;
            this.Magazine = Magazine;
        }
    }
}
