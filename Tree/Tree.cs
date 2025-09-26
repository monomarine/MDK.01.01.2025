using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Tree
    {
        public Node Root { get;  set; } //корень дерева
        public Tree()
        {
            Root = null;
        }

        public Node CreateBalancedTree(int nodeCount)
        {
            if (nodeCount == 0)
                return null;

            Console.WriteLine($"Введите данные для узла {nodeCount}:");

            Console.Write("ФИО: ");
            string fio = Console.ReadLine();

            Console.Write("Дата рождения: ");
            string dateInput = Console.ReadLine();

            try
            {
                DateTime birthDate = DateTime.ParseExact(dateInput, "dd.MM.yyyy", null);
                People people = new People(fio, birthDate);

                Node root = new Node(people);
                root.Left = CreateBalancedTree(nodeCount / 2);
                root.Right = CreateBalancedTree(nodeCount - nodeCount / 2 - 1);

                return root;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода даты: {ex.Message}. Повторите ввод.");
                return CreateBalancedTree(nodeCount);
            }
        }

        private Node AddNodeRecursive(Node node, People people)
        {
            if (node == null)
                return new Node(people);

            int result = string.Compare(node.Value.FIO, people.FIO);

            if (result < 0)
                node.Left = AddNodeRecursive(node.Left, people);
            else if (result > 0)
                node.Right = AddNodeRecursive(node.Right, people);

            return node;
        }

        public void AddNode(People people) =>
            Root = AddNodeRecursive(Root, people);

        private void TreeTravelsalR(Node node, List<People> results)
        {
            if (node != null)
            {
                results.Add(node.Value);
                TreeTravelsalR(node.Left, results);
                TreeTravelsalR(node.Right, results);

            }
        }

        public List<People> TreeTravelsal()
        {
            List<People> results = new List<People>();
            TreeTravelsalR(Root, results);
            return results;
        }

        private bool FindNodeR(Node node, string fio)
        {
            if (node == null) return false;
            int result = string.Compare(node.Value.FIO, fio);
            if (result == 0)
                return true;
            else if (result < 0)
                return FindNodeR(node.Left, fio);
            else
                return FindNodeR(node.Right, fio);

        }

        public bool FindNode(string fio) =>
            FindNodeR(Root, fio);

        private Node DeleteNodeR(Node node, string fio)
        {
            if (node == null) return null;

            int result = string.Compare(node.Value.FIO, fio);
            if (result < 0)
                node.Left = DeleteNodeR(node.Left, fio);
            else if (result > 0)
                node.Right = DeleteNodeR(node.Right, fio);

            else // удаление найденного элмента
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                // TODO найти меньший элемент в правом поддере

                node.Value = FindMinValue(node.Right);
                node.Right = DeleteNodeR(node.Right, node.Value.FIO);
                
            }
            return node;
        }

        private People FindMinValue(Node node)
        {
            People minValue = node.Value;

            while(node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }

        public void DeleteNode(string fio) =>
            DeleteNodeR(Root, fio);



        private void MiddleAgeR(Node node, ref int totalAge, ref int count)
        {
            if (node != null)
            {
                totalAge += node.Value.Age;
                count++;
                MiddleAgeR(node.Left, ref totalAge, ref count);
                MiddleAgeR(node.Right, ref totalAge, ref count);
            }
        }

        public double MiddleAge()
        {
            int totalAge = 0;
            int count = 0;
            MiddleAgeR(Root, ref totalAge, ref count);

            return count > 0 ? (double)totalAge / count : 0;
        }

    }





}
