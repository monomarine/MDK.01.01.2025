using System.Diagnostics;

namespace Garbage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анализ сборщика мусора");

            long initialMemory = GC.GetTotalMemory(false);
            Console.WriteLine($"Начальная память: {initialMemory} байт");

            Stopwatch stopwatch = Stopwatch.StartNew();

            Analysis.TestSmallCollection();

            Analysis.TestLargeCollection();

            Analysis.TestCollectionWithChanges();

            stopwatch.Stop();
            
            long finalMemory = GC.GetTotalMemory(true);
            Console.WriteLine($"\nФинальная память: {finalMemory} байт");
            Console.WriteLine($"Общее время выполнения: {stopwatch.ElapsedMilliseconds} мс");
            
            Analysis.PrintGCStats();
        }
    }
}
