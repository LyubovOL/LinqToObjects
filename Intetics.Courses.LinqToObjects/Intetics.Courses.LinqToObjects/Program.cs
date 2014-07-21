﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Intetics.Courses.LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group("153501");
            var group2 = new Group("153502");

            var st1 = new Student("Вася", "Иванов", 20);
            var st2 = new Student("Антон", "Сидоров", 24);
            var st3 = new Student("Никита", "Емельянов", 19);
            var st4 = new Student("Семен", "Поддубный", 18);

            group1.Students.Add(st1);
            group1.Students.Add(st2);
            group2.Students.Add(st3);
            group2.Students.Add(st4);

            IOperation<Student> operation = new Operation<Student>();
            var averageAge1 = operation.GetAverageAge(group1.Students);
            var averageAge2 = operation.GetAverageAge(group2.Students);
            Console.WriteLine(String.Format("Average age in group №{1} : {0}", averageAge1, group1.Number));
            Console.WriteLine(String.Format("Average age in group №{1} : {0}", averageAge2, group2.Number));
            Console.ReadLine();
        }
    }
}
