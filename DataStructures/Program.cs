using LinkedList;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLinkedList list = new SLinkedList();
            list.AddFirst("first");
            list.AddLast("second");
            list.AddFirst("three");
            
            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
