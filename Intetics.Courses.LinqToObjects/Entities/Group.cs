using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intetics.Courses.LinqToObjects.Entitites;

namespace Entities
{
    public class Group
    {
        public string Number { get; set; }
        public ICollection<Student> Students { get; set; }

        public Group(string number)
        {
            this.Number = number;
            this.Students = new Collection<Student>();
        }
    }
}
