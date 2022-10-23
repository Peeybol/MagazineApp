using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Area
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [InverseProperty("BelongingArea")]
        public virtual ICollection<Paper> Papers
        {
            get;
            set;
        }

        [InverseProperty("EvaluationPendingArea")]
        public virtual ICollection<Paper> EvaluationPending
        {
            get;
            set;
        }
        [InverseProperty("PublicationPendingArea")]
        public virtual ICollection<Paper> PublicationPending
        {
            get;
            set;
        }
        [Required]
        public virtual Magazine Magazine
        {
            get;
            set;
        }


        [Required]
        public virtual User Editor
        {
            get;
            set;
        }
    }
}
