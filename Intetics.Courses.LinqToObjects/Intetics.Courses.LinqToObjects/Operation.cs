using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intetics.Courses.LinqToObjects.Entitites;

namespace Intetics.Courses.LinqToObjects
{
    public class Operation: IOperation
    {
        public float GetAverageAge<T>(ICollection<T> objects)
        {
            return objects.Average<T>();
        }
    }
}
