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

            list.AddEnd("КОнец");
            list.AddEnd("Конец2");
            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
