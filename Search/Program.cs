using System.Collections.Immutable;
using System.Diagnostics;
using System.Net.WebSockets;

namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int key = 10000000;
            int[] array = GetSortedArray(key);
            HashSet<int> set = array.ToHashSet<int>();
            sw.Start();
            int foundedLinear = Search.LinearSearch(key, array);
            sw.Stop();
			Console.WriteLine($"Found: {foundedLinear} Elapsed: {sw.ElapsedTicks} ticks");
			sw.Restart();
            int foundedBinary = Search.IterativeBinarySearch(key, array);
            sw.Stop();
            Console.WriteLine($"Found: {foundedBinary} Elapsed: {sw.ElapsedTicks} ticks");
            sw.Restart();
            set.Contains(key);
            sw.Stop();
            Console.WriteLine($"HashSet Elapsed: {sw.ElapsedTicks} ticks");
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

        static int[] GetSortedArray(int count)
        {
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = i;
            }
            return array;
        }
       
    }
}
