using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Entities
{
    public class Group
    {
        public string Number { get; set; }
        public ICollection<IPerson> Students { get; set; }

        public Group(string number)
        {
            this.Number = number;
            this.Students = new Collection<IPerson>();
        }
    }
}
