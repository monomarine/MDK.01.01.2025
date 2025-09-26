namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

             tree.AddNode("Tom");
             tree.AddNode("Bob");
             tree.AddNode("Mag");
            tree.AddNode("1");
            tree.AddNode("5");
            tree.AddNode("3");
            tree.AddNode("4");
            tree.AddNode("2");

            var res = tree.TreeTraversal();
            foreach (var item in res) 
                Console.WriteLine(item);

            tree.DeleteNode("1");
            var res2 = tree.TreeTraversal();
            foreach (var item in res2)
                Console.WriteLine(item);
        }
    }
}
