using System.Collections.Immutable;
using System.Diagnostics;

namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 1000, 10_000, 100_000, 1_000_000 };

            foreach (int size in sizes)
            {
                Console.WriteLine($"\n=== N = {size:N0} ===");
                Console.WriteLine(new string('=', 50));

                int key = size * 10; 
                var data = GetArray(size, key);
                var hashSet = new HashSet<int>(data);

                MeasureTime("Линейный поиск в массиве", () =>
                {
                    int result = Search.LinearSearch(key, data);
                    if (result == -1) throw new Exception("Элемент не найден");
                });

                MeasureTime("Бинарный поиск в массиве", () =>
                {
                    int result = Search.IterativeBinarySearch(key, data);
                    if (result == -1) throw new Exception("Элемент не найден");
                });

                MeasureTime("Поиск в HashSet", () =>
                {
                    bool result = hashSet.Contains(key);
                    if (!result) throw new Exception("Элемент не найден");
                });

                Console.WriteLine();
            }
        }

        static int[] GetArray(int count, int key)
        {
            int[] array = new int[count];
            Random rand = new Random();

            for (int i = 0; i < count - 1; i++)
            {
                array[i] = rand.Next(0, key - 1);
            }

            array[count - 1] = key;
            Array.Sort(array);

            return array;
        }

        static void MeasureTime(string operationName, Action action)
        {
            for (int i = 0; i < 10; i++)
            {
                action();
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();

            Console.WriteLine($"{operationName,-30} | Время: {stopwatch.ElapsedTicks,10} тиков");
        }
    }
}