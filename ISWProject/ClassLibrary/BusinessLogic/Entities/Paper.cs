using System;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper()
        {
            Evaluation = new Evaluation();
            CoAuthors = new ICollection<Person>;
            Responsible = new User();
            Issue = new Issue();
            BelongingArea = new Area();
            EvaluationPendingArea = new Area();
            PublicationPendingArea = new Area();
        }

        public Paper(int id, string title, DateTime uploadTime):this() {
            Id = id;
            Title = title;
            UploadTime = uploadTime;
        }
    }
}
