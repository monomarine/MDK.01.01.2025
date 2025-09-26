namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tree tree = new Tree();

            // tree.AddNode("Tom");
            // tree.AddNode("Bob");
            // tree.AddNode("Mag");
            //tree.AddNode("1");
            //tree.AddNode("5");
            //tree.AddNode("3");
            //tree.AddNode("4");
            //tree.AddNode("2");

            //var res = tree.TreeTraversal();
            //foreach (var item in res) 
            //    Console.WriteLine(item);

            //tree.DeleteNode("1");
            //var res2 = tree.TreeTraversal();
            //foreach (var item in res2)
            //    Console.WriteLine(item);

            Tree tree = new Tree();

            tree.AddNode("Tom", new DateOnly(1990, 5, 15));
            tree.AddNode("Bob", new DateOnly(1985, 3, 20));
            tree.AddNode("Mag", new DateOnly(1995, 7, 10));
            tree.AddNode("Alice", new DateOnly(2000, 1, 5));
            tree.AddNode("John", new DateOnly(1975, 12, 25));

            Console.WriteLine("Люди в дереве:");
            var people = tree.TreeTraversal();
            foreach (var person in people)
                Console.WriteLine(person);

            Console.WriteLine($"\nСредний возраст: {tree.GetAverageAge():F2} лет");
        }
    }
}
