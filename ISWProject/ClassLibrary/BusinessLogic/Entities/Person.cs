using System.Collections.Generic;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Person 
    {
        public Person()
        {
            CoAuthoredPapers = new List<Paper>();
        }
        
        public Person(string Id, string Name, string Surname):this()
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
        }

        
    }
}
