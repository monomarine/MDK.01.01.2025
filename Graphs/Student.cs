using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Student
    {
        public string Name { get; set; }
        public float AcademicPerformance { get; set; }
        public Student(string name, float performance)
        {
            Name = name;
            AcademicPerformance = performance;
        }
    }
}
