using System;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Evaluation()
        {
        }
        public Evaluation(bool Accepted, string Comments, DateTime Date):this()
        {
            this.Accepted = Accepted;
            this.Comments = Comments;
            this.Date = Date;
        }

    }
}
