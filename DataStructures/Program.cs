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
            list.AddFirst("third");
            list.AddLast("zeroth");
            list.AddLast("minus first");
            list.AddLast("minus second");


            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
