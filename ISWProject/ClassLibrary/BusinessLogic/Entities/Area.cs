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

        public Area(string Name, User Editor, Magazine Magazine):this()
        { 
            this.Name = Name;
            this.Editor = Editor;
            this.Magazine = Magazine;
        }
    }
}
