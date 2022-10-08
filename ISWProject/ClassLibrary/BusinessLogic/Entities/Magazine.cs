using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            Areas = new List<Area>();
            Issues = new List<Issue>();
        }

        public Magazine(string Name, User ChiefEditor):this()
        {
            this.Name = Name;
            this.ChiefEditor = ChiefEditor;
        }
    }
}
