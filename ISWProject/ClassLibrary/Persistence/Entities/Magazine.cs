using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Area> Areas
        {
            get;
            set;
        }
        public virtual ICollection<Issue> Issues
        {
            get;
            set;
        }
        public virtual User ChiefEditor
        {
            get;
            set;
        }
    }
}
