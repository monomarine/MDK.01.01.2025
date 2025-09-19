using LinkedList;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLinkedList list = new SLinkedList();
            list.AddFirst("3");
            list.AddFirst("2");
            list.AddFirst("1");

            list.AddLast("4");

            
            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
