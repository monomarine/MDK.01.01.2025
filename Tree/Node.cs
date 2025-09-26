#pragma warning disable
using System;

namespace Tree
{
    internal class Node
    {
        public Person Value { get; set; } 
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(Person value = null, Node left = null, Node right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }
    }
}