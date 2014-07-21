using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Intetics.Courses.LinqToObjects
{
    public class Operation<T>: IOperation<T> where T: Student
    {
        public double GetAverageAge(ICollection<T> objects)
        {
            return objects.Average(student => student.Age);
        }
    }
}
