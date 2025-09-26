using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Node
    {
        public string Value { get; set; }
        public List<Node> Neighbors { get; set; }

        public Student Student { get; set; }

        public Node(string value)
        {
            Value = value;  
            Neighbors = new List<Node>();
        }

        public Node(Student student)
        {
            Student = student;
            Value = student?.FullName;
            Neighbors = new List<Node>();
        }



        public override string ToString()
        {
            return Student != null ? Student.ToString() : Value;
        }
    }
}
