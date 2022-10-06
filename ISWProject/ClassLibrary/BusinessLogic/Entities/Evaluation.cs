using System;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Evaluation()
        {
            Paper = new Paper();
        }
        public Evaluation(Boolean Accepted, String Comments, DateTime Date, int Id):this()
        {
            this.Accepted = Accepted;
            this.Comments = Comments;
            this.Date = Date;
            this.Id = Id;
        }

    }
}
