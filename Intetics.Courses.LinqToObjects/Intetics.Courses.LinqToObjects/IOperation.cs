using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Intetics.Courses.LinqToObjects
{
    public interface IOperation<T> where T : IPerson
    {
        double GetAverageAge(ICollection<T> objects);
    }
}
