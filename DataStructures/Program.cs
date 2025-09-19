using LinkedList;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLinkedList list = new SLinkedList();
            list.AddFirst("first");
            list.AddFirst("second");
            list.AddFirst("three");
            list.AddLast("fourth");

            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
