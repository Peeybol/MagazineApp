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
        }

        public Magazine(int Id, string Name):this()
        {
            this.Id = Id;
            this.Name = Name;
            ChiefEditor = new User();
        }
    }
}
