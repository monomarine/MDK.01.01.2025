using System.Collections.Immutable;
using System.Net.WebSockets;

namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = 100000;
            int[] data = GetArray(100000, key);
            Search.RecursiveBinarySearch(key, data);
            Search.LinearSearch(key, data);
            Search.InterpolateSearch(key, data);

            Console.WriteLine();
            int key2 = 100000;
            int[] data2 = GetArray(100000, key2);


            Console.WriteLine();
            int key3 = 300000;
            int[] data3 = GetArray(300000, key3);


            Console.WriteLine(Search.IterativeBinarySearch(key3, data3));
            Console.WriteLine(Search.LinearSearch(key3, data3));
            Console.WriteLine(Search.InterpolateSearch(key3, data3));

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
