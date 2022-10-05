using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            ChiefEditor = new User();
        }

        public User ChiefEditor
        {
            get;
            set;
        }

        public Magazine(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
