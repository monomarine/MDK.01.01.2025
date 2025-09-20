using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
#pragma warning disable

    internal class Node //узел стека
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}
