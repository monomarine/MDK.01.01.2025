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

        public GraphByList(Student rootStudent)
        {
            this.root = new Node(rootStudent);
        }

        public Node AddNode(Student student, Node parent = null)
        {
            Node newNode = new Node(student);
            if (parent == null)
            {
                newNode.Neighbors.Add(root);
                root.Neighbors.Add(newNode);
            }
            else
            {
                newNode.Neighbors.Add(parent);
                parent.Neighbors.Add(newNode);
            }
            return newNode;
        }

        public void RemoveNode(Node node)
        {
            if (node == null) return;
            foreach (Node child in node.Neighbors)
            {
                child.Neighbors.Remove(node);
            }
            node.Neighbors.Clear();
            node = null;
        }
        #region ОбходВГлубину
        private void DephtRecursive(Node startNode)
        {
            if (startNode == null || vector.Contains(startNode)) return; //базовый случай
            vector.Add(startNode);
            Console.WriteLine(startNode);
            foreach (Node child in startNode.Neighbors)
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

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                Console.WriteLine(current.Value.Name);
                foreach (Node child in current.Neighbors)
                {
                    if (!vector.Contains(child))
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
            if (n1 == null || n2 == null) return;
            if (n1 == null)
            {
                root.Neighbors.Add(n2);
                n2.Neighbors.Add(root);
            }
            if (n2 == null)
            {
                root.Neighbors.Add(n1);
                n1.Neighbors.Add(root);
            }
            if (!n1.Neighbors.Contains(n2))
                n1.Neighbors.Add(n2);
            if (!n2.Neighbors.Contains(n1))
                n2.Neighbors.Add(n1);

        }
        public void RemoveEdge(Node n1, Node n2)
        {
            if (n1 == null || n2 == null) return;
            if (n1.Neighbors.Contains(n2))
                n1.Neighbors.Remove(n2);
            if (n2.Neighbors.Contains(n1))
                n2.Neighbors.Remove(n1);
        }

        private Node FindNodeRecursive(string findValue, Node startNode)
        {
            if (startNode == null || vector.Contains(startNode)) return null; //базовый случа й

            vector.Add(startNode);
            if (startNode.Value.Name == findValue)
                return startNode;

            foreach (Node child in startNode.Neighbors)
            {
                Node result = FindNodeRecursive(findValue, child);
                if (result != null) return result;
            }
            return null;
        }
        public Node FindNode(string findValue, Node startNode = null)
        {
            vector = new HashSet<Node>();
            return FindNodeRecursive(findValue, startNode);
        }

        //Метод поиска средней успеваемости всех студентов
        public float CalculateAveragePerformance()
        {
            if (root == null) return 0f;
            vector = new HashSet<Node>();
            Queue<Node> queue = new Queue<Node>();
            float totalPerformance = 0f;
            int count = 0;


            queue.Enqueue(root);
            vector.Add(root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                totalPerformance += current.Value.AcademicPerformance;
                count++;
                foreach (Node neighbor in current.Neighbors)
                {
                    if (!vector.Contains(neighbor))
                    {
                        vector.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return count > 0 ? totalPerformance / count : 0f;
        }

        //Поиск самого общительного студента
        public Node FindMostCommunicativeStudent()
        {
            if (root == null) return null;

            vector = new HashSet<Node>();
            Queue<Node> queue = new Queue<Node>();
            Node mostCommunicative = null;
            int maxNeighbors = -1;


            queue.Enqueue(root);
            vector.Add(root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();

                int currentNeighborsCount = current.Neighbors.Count;
                if (currentNeighborsCount > maxNeighbors)
                {
                    maxNeighbors = currentNeighborsCount;
                    mostCommunicative = current;
                }

                foreach (Node neighbor in current.Neighbors)
                {
                    if (!vector.Contains(neighbor))
                    {
                        vector.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return mostCommunicative;
        }

    }
}
