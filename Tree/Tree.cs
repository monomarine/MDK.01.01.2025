using System;
using System.Collections.Generic;

namespace Tree
{
    internal class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            Root = null;
        }

        #region ДобавлениеУзла
        private Node AddNodeRecursive(Node node, Person person)
        {
            if (node == null)
                return new Node(person);

            int result = string.Compare(node.Value.Name, person.Name);
            if (result > 0)
                node.Left = AddNodeRecursive(node.Left, person);
            else if (result < 0)
                node.Right = AddNodeRecursive(node.Right, person);

            return node;
        }

        public void AddNode(Person person) =>
            Root = AddNodeRecursive(Root, person);

        // Перегрузка для удобства
        public void AddNode(string name, DateTime birthDate) =>
            AddNode(new Person(name, birthDate));
        #endregion

        #region Удаление узла
        private Node DeleteNodeRecursive(Node node, string name)
        {
            if (node == null) return null;

            int result = string.Compare(name, node.Value.Name);
            if (result < 0)
                node.Left = DeleteNodeRecursive(node.Left, name);
            else if (result > 0)
                node.Right = DeleteNodeRecursive(node.Right, name);
            else
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                node.Value = FindMinValue(node.Right);
                node.Right = DeleteNodeRecursive(node.Right, node.Value.Name);
            }
            return node;
        }

        private Person FindMinValue(Node node)
        {
            Node current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Value;
        }

        public void DeleteNode(string name) =>
            Root = DeleteNodeRecursive(Root, name);
        #endregion

        #region ОбходДереваRLR (прямой обход)
        private void TreeTraversalRecursive(Node node, List<Person> results)
        {
            if (node != null)
            {
                results.Add(node.Value);
                TreeTraversalRecursive(node.Left, results);
                TreeTraversalRecursive(node.Right, results);
            }
        }

        public List<Person> TreeTraversal()
        {
            List<Person> results = new List<Person>();
            TreeTraversalRecursive(Root, results);
            return results;
        }
        #endregion

        #region Расчет среднего возраста
        private void CalculateAgeStatsRecursive(Node node, ref int totalAge, ref int personCount)
        {
            if (node != null)
            {
                totalAge += node.Value.Age;
                personCount++;
                CalculateAgeStatsRecursive(node.Left, ref totalAge, ref personCount);
                CalculateAgeStatsRecursive(node.Right, ref totalAge, ref personCount);
            }
        }

        public (double averageAge, int totalPeople) CalculateAverageAge()
        {
            int totalAge = 0;
            int personCount = 0;

            CalculateAgeStatsRecursive(Root, ref totalAge, ref personCount);

            double averageAge = personCount > 0 ? (double)totalAge / personCount : 0;
            return (averageAge, personCount);
        }
        #endregion

        #region ПоискУзлаПоЗначению
        private bool FindNodeRecursive(Node node, string name)
        {
            if (node == null) return false;

            int result = string.Compare(node.Value.Name, name);
            if (result == 0)
                return true;
            else if (result > 0)
                return FindNodeRecursive(node.Left, name);
            else
                return FindNodeRecursive(node.Right, name);
        }

        public bool FindNode(string name) =>
            FindNodeRecursive(Root, name);
        #endregion
    }
}