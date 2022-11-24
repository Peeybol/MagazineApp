using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper()
        {
            CoAuthors = new List<Person>();
        }

        public Paper(string title, DateTime uploadTime, Area BelongingArea, User Responsible):this() {
            this.Title = title;
            this.UploadDate = uploadTime;
            this.Responsible = Responsible;
            this.BelongingArea = BelongingArea;
            CoAuthors.Add(Responsible);
        }

        public void AddCoauthor (Person person)
        {
            CoAuthors.Add(person);
        }
    }
}
