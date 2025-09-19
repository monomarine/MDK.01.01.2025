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
            //поменял three на third
            list.AddFirst("third");
            list.AddFirst("fourth");
            //добавляем данные в конец
            list.AddLast("fifth");
            list.AddLast("sixth");

            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
