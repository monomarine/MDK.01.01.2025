using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Student
    {
        public string FullName { get; set; }
        public double AverageGrades { get; set; }

        public Student (string fullName, double averageGrades)
        {
            FullName = fullName;
            AverageGrades = averageGrades;
        }
        public override string ToString()
        {
            return $"{FullName}: {AverageGrades:F2}";
        }
    }
}
