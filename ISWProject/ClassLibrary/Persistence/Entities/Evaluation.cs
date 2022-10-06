using System;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Boolean Accepted
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public int Id
        {
            get;
            set;
        }
        public virtual Paper Paper
        {
            get;
            set;
        }
    }
}
