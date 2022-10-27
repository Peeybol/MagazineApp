using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        // [Key]
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

        [Required]
        public virtual User ChiefEditor
        {
            get;
            set;
        }
    }
}
