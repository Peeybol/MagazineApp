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
            CoAuthors = new ICollection<Person>;
        }

        public Paper(int id, string title, DateTime uploadTime):this() {
            Id = id;
            Title = title;
            UploadTime = uploadTime;
            Responsible = new User();
            BelongingArea = new Area();
        }
    }
}
