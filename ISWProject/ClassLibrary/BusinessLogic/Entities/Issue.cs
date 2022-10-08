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

        public Issue (int Number, Magazine Magazine):this()
        {
            this.Number = Number;
            this.PublicationDate = null;
            this.Magazine = Magazine;
        }
    }
}
