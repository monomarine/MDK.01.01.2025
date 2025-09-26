namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

             tree.AddNode("Tom");
             tree.AddNode("Mag");
             tree.AddNode("Bob");


            var res = tree.TreeTraversal();

            foreach (var item in res) 
                Console.WriteLine(item);
            Console.ReadKey();
           
        }
    }
}
