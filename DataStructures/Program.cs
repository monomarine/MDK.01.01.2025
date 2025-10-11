using LinkedList;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLinkedList list = new SLinkedList();
            list.AddFirst("Первый");
            list.AddFirst("Второй");
            list.AddFirst("Третий");
            list.InsertAfter("Второй", "Четвертый");
            list.AddLast("Пятый");

            Console.WriteLine("=Изначальный список=");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=Список после удаления Четвертый=");
            list.Remove("Четвертый");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=Перевернутый список=");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"=Есть ли в списке Пятый? {list.Contains("Пятый")}=");
            Console.WriteLine("=Удаляем первый элемент=");
            list.RemoveFirst();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"=Есть ли в списке Пятый? {list.Contains("Пятый")}=");
            Console.WriteLine("=Удаляем последний элемент=");
            list.RemoveLast();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=Очищаем=");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
