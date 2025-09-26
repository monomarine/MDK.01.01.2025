using System;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            
            tree.AddNode("Tom", new DateTime(1990, 5, 15));
            tree.AddNode("Bob", new DateTime(1985, 3, 20));
            tree.AddNode("Mag", new DateTime(1995, 7, 10));
            tree.AddNode("Alice", new DateTime(2000, 1, 5));
            tree.AddNode("John", new DateTime(1978, 12, 25));
            tree.AddNode("Emma", new DateTime(1992, 8, 30));
            tree.AddNode("David", new DateTime(1988, 11, 12));
            tree.AddNode("Sarah", new DateTime(1998, 4, 18));

            Console.WriteLine("Обход дерева (прямой обход):");
            var people = tree.TreeTraversal();
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            
            var ageStats = tree.CalculateAverageAge();
            Console.WriteLine($"\nСтатистика возраста:");
            Console.WriteLine($"Всего людей: {ageStats.totalPeople}");
            Console.WriteLine($"Средний возраст: {ageStats.averageAge:F2} лет");

            
            Console.WriteLine("\nПосле удаления Alice:");
            tree.DeleteNode("Alice");

            var peopleAfterDeletion = tree.TreeTraversal();
            foreach (var person in peopleAfterDeletion)
            {
                Console.WriteLine(person);
            }

            var newAgeStats = tree.CalculateAverageAge();
            Console.WriteLine($"\nНовая статистика возраста:");
            Console.WriteLine($"Всего людей: {newAgeStats.totalPeople}");
            Console.WriteLine($"Средний возраст: {newAgeStats.averageAge:F2} лет");

            
            string searchName = "Bob";
            bool found = tree.FindNode(searchName);
            Console.WriteLine($"\nПоиск '{searchName}': {(found ? "найден" : "не найден")}");

            Console.ReadLine();
        }
    }
}