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

        public Paper(int id, string title, DateTime uploadTime):this() {
            this.Id = id;
            this.Title = title;
            this.UploadDate = uploadTime;
            this.Responsible = new User();
            this.BelongingArea = new Area();
        }
    }
}
