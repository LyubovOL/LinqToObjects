using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intetics.Courses.LinqToObjects
{
    public interface IOperation
    {
        float GetAverageAge<T>(ICollection<T> objects);
    }
}
