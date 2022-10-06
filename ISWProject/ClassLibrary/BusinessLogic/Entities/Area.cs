using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Area
    {
        public Area()
        {
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();

        }

        public Area(int Id, string Name):this()
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
