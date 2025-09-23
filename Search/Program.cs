using System.Collections.Immutable;
using System.Net.WebSockets;

namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = 64655;
            int[] data = GetArray(100, key);

            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Search.IterativeBinarySearch(4, data));
            Console.WriteLine(Search.LinearSearch(4, data));
            Console.WriteLine(Search.InterpolateSearch(4, data));
        }

        static int[] GetArray(int count, int key)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(0, key);
            }
            array[count - 1] = key;
            Array.Sort(array);
            return array;
        }
       
    }
}
