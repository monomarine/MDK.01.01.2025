using LinkedList;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLinkedList list = new SLinkedList();
            list.AddFirst("1");
            list.AddFirst("2");
            list.AddFirst("3");
            list.InsertAfter("2", "4");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
