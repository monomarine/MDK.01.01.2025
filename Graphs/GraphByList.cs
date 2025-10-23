using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class GraphByList
    {
        private Node root; //самый первый узел добавленный в граф
        private HashSet<Node> vector;

        public GraphByList(Student rootValue)
        {
            this.root = new Node(rootValue);
        }

        public Node AddNode(Student student, Node parent = null)
        {
            Node newNode = new Node(student);
            if(parent == null)
            {
                newNode.Friends.Add(root);
                root.Friends.Add(newNode);
            }
            else
            {
                newNode.Friends.Add(parent);
                parent.Friends.Add(newNode);
            }
            return newNode;
        }

        public void RemoveNode(Node node)
        {
            if (node == null) return;
            foreach (Node child in node.Friends)
            {
                child.Friends.Remove(node);
            }
            node.Friends.Clear();
            node = null;
        }
        #region ОбходВГлубину
        private void DephtRecursive(Node startNode)
        {
            if(startNode == null || vector.Contains(startNode)) return; //базовый случа й
            vector.Add(startNode);
            Console.WriteLine(startNode);
            foreach (Node child in startNode.Friends)
                DephtRecursive(child);
        }
        public void Depht(Node startNode = null)
        {
            vector = new HashSet<Node>();
            DephtRecursive(startNode ?? root);
        }
        #endregion

        #region ОбходВШиррину
        public void Width(Node node = null)
        {
            Queue<Node> queue = new Queue<Node>();  
            vector = new HashSet<Node>();

            Node start = node ?? root;
            queue.Enqueue(start);
            vector.Add(start);

            while(queue.Count > 0)
            {
                Node current = queue.Dequeue();
                Console.WriteLine(current.Student);
                foreach (Node child in current.Friends)
                {
                    if(!vector.Contains(child))
                    {
                        vector.Add(child);
                        queue.Enqueue(child);
                    }
                }
            }
        }

        #endregion

        public void AddEdge(Node n1, Node n2)
        {
            if (n1 == null && n2 == null) return;
            else if (n1 == null || n2 == null)
            {
                n1 = n1 ?? n2;
                n1.Friends.Add(root);
                root.Friends.Add(n1);
                return;
            }

            if (!n1.Friends.Contains(n2))
                n1.Friends.Add(n2);
            if(!n2.Friends.Contains(n1))
                n2.Friends.Add(n1);
        }
        public void RemoveEdge(Node n1, Node n2)
        {
            if (n1 == null || n2 == null) return;
            if(n1.Friends.Contains(n2))
                n1.Friends.Remove(n2);
            if(n2.Friends.Contains(n1))
                n2.Friends.Remove(n1);
        }

        private Node FindNodeRecursive(Student findValue, Node startNode)
        {
            if (startNode == null || vector.Contains(startNode)) return null; //базовый случа й
            
            vector.Add(startNode);
            if(startNode.Student == findValue)
                return startNode;
            
            foreach (Node child in startNode.Friends)
            {
                Node result = FindNodeRecursive(findValue, child);
                if (result != null) return result;
            }
            return null;
        }
        public Node FindNode(Student findValue, Node startNode = null)
        {
            vector = new HashSet<Node>() ;
            return FindNodeRecursive(findValue, startNode);
        }

        public Student GetPopularStudent()
        {
            if(vector == null || vector.Count == 0)
                Width();
            Node popularNode = root;
            foreach (var node in vector)
            {
                if (node.Friends.Count > popularNode.Friends.Count)
                    popularNode = node;
            }
            return popularNode.Student;
        }

    }
}
