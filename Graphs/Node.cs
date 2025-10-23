using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Node
    {
        public Student Student { get; set; }
        public List<Node> Friends { get; set; }

        public Node(Student student)
        {
            Student = student;
            Friends = new List<Node>();
        }

        public override string ToString() => Student.ToString();
    }
}
