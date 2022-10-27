using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        //[Key]
        public int Id
        {
            get;
            set;
        }
    }
}
