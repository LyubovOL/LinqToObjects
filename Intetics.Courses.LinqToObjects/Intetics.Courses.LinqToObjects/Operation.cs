using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Intetics.Courses.LinqToObjects
{
    public class Operation<T>: IOperation<T> where T: IPerson
    {
        public double GetAverageAge(ICollection<T> objects)
        {
            return objects.Average(person => person.Age);
        }
    }
}
