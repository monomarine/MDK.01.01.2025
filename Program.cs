using System.Collections.Immutable;
using System.Net.WebSockets;

namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = 64655;
            int[] sizes = { 100, 100000, 3000000 };

            Console.WriteLine("КЛЮЧ В КОНЦЕ ПОСЛЕДОВАТЕЛЬНОСТИ");
            foreach (int size in sizes)
            {
                Console.WriteLine($"\n размер массива: {size}");
                int[] data = GetArray(size, key, true);
                Search.LinearSearch(key, data);
                Search.IterativeBinarySearch(key, data);
                Search.InterpolateSearch(key, data);
            }

            Console.WriteLine("\n КЛЮЧ В СЛУЧЙНОМ МЕСТЕ ПОСЛЕДОВАТЕЛЬНОСТИ");
            foreach (int size in sizes)
            {
                Console.WriteLine($"\n размер массива: {size}");
                int[] data = GetArray(size, key, false);
                Search.LinearSearch(key, data);
                Search.IterativeBinarySearch(key, data);
                Search.InterpolateSearch(key, data);
            }
        }

        static int[] GetArray(int count, int key, bool keyAtEnd = true)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(0, key);
            }
            if (keyAtEnd)
            {
                array[count - 1] = key;
            }
            else
            {
                int randomIndex = rand.Next(0, count);
                array[randomIndex] = key;
            }

            Array.Sort(array);
            return array;
        }
       
    }
}
