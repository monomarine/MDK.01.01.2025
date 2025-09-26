using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            Console.WriteLine("Введите имя человека:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите год рождения:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения:");
            int day = int.Parse(Console.ReadLine());

            People people = new People(name, new DateOnly(year, month, day));
            Node root = new Node(people);

            root.Left = CreateBalancedTree(nodeCount / 2);
            root.Right = CreateBalancedTree(nodeCount - nodeCount / 2 - 1);

            return root;
        }
        #region ДобавлениеУзла
        private Node AddNodeRecursive(Node node, People people)
        {
            if(node == null) //базовый случай - не встретилось совпадений
                return new Node(people);
            int result = string.Compare(people.FullName, node.People.FullName);
            if(result > 0)
                node.Left = AddNodeRecursive(node.Left, people);
            else if( result < 0)
                node.Right = AddNodeRecursive(node.Right, people);

            return node;
        }
        public void AddNode(string fullname, DateOnly birthday)
        {
            People people = new People(fullname, birthday);
            Root = AddNodeRecursive(Root, people);

        }
        #endregion

        #region Удаление узла
        private Node DeleteNodeRecursive(Node node, string text)
        {
            if (node == null) return null;
            int result = string.Compare(text, node.People.FullName);
            if(result < 0)
                node.Left = DeleteNodeRecursive(node.Left, text);
            else if(result > 0)
                node.Right = DeleteNodeRecursive(node.Right, text);
            else //удаление найденного элемента
            {
                if (node.Left == null)
                    return node.Right;
                else if(node.Right == null)
                    return node.Left;

                node.People.FullName = FindMinValue(node.Right);
                node.Right = DeleteNodeRecursive(node.Right, node.People.FullName);

            }
            return node;
        }
        private string FindMinValue(Node node)
        {
            Node current = node;
            while (current.Left != null)
            {
                current = current.Left; 
            }
            return current.People.FullName;
        }
        public void DeleteNode(string text)=>
            Root = DeleteNodeRecursive(Root, text);
        #endregion

        #region ОбходДереваRLR
        private void TreeTravelsalRecursive(Node node, List<People> results)
        {
            if(node!=null)
            {
                results.Add(node.People);
                TreeTravelsalRecursive(node.Left, results);
                TreeTravelsalRecursive(node.Right, results);
            }
        }
        public List<People> TreeTraversal()
        {
            List<People> results = new List<People>();
            TreeTravelsalRecursive(Root, results);
            return results;
        }
        #endregion

        #region ПоискУзлаПоЗначению
        private bool FindNodeRecursive(Node node, string text)
        {
            if(node==null) return false;
            int resurt = string.Compare(node.People.FullName, text);
            if (resurt == 0)
                return true;
            else if (resurt < 0)
                return FindNodeRecursive(node.Left, text);
            else
                return FindNodeRecursive(node.Right, text);
        }
        public bool FindNode(string text)=>
            FindNodeRecursive(Root, text);

        #endregion


        public double GetAverageAge()
        {
            var people = TreeTraversal();
            if (people.Count == 0)
                return 0;

            int totalAge = 0;
            foreach (var person in people)
            {
                totalAge += person.Age;
            }

            return (double)totalAge / people.Count;
        }
    }
}
