using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Garbage
{
    internal class Analysis
    {
        public static void TestSmallCollection()
        {
            Console.WriteLine("\n100 объектов:");

            long memoryBefore = GC.GetTotalMemory(false);
            int gcCountBefore = GC.CollectionCount(0);

            List<Garbage> smallCollection = new List<Garbage>();

            for (int i = 0; i < 100; i++)
            {
                smallCollection.Add(new Garbage($"Объёкт{i}", 10, 512));
            }

            long memoryAfterCreation = GC.GetTotalMemory(false);
            Console.WriteLine($"Память после создания: {memoryAfterCreation} байт");
            Console.WriteLine($"Использовано памяти: {memoryAfterCreation - memoryBefore} байт");

            for (int i = 0; i < 50; i++)
            {
                smallCollection[i] = new Garbage($"Новый обхект_{i}", 15, 1024);
            }

            for (int i = 0; i < 25; i++)
            {
                smallCollection[i] = null;
            }

            GC.Collect();

            int gcCountAfter = GC.CollectionCount(0);
            long memoryAfterGC = GC.GetTotalMemory(true);

            Console.WriteLine($"Сборок мусора Gen 0: {gcCountAfter - gcCountBefore}");
            Console.WriteLine($"Память после GC: {memoryAfterGC} байт");
        }

        public static void TestLargeCollection()
        {
            Console.WriteLine("\n10000 объектов:");

            long memoryBefore = GC.GetTotalMemory(false);
            int gcCountBefore = GC.CollectionCount(0);

            List<Garbage> largeCollection = new List<Garbage>();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000; i++)
            {
                largeCollection.Add(new Garbage($"Объект побольше{i}", 100, 2048));

                if (i % 1000 == 0)
                {
                    GC.Collect(0, GCCollectionMode.Optimized);
                }
            }

            sw.Stop();
            long memoryAfterCreation = GC.GetTotalMemory(false);

            Console.WriteLine($"Время создания: {sw.ElapsedMilliseconds} мс");
            Console.WriteLine($"Память после создания: {memoryAfterCreation} байт");
            Console.WriteLine($"Использовано памяти: {memoryAfterCreation - memoryBefore} байт");

            sw.Restart();
            for (int i = 0; i < 5000; i++)
            {
                if (i % 2 == 0)
                {
                    largeCollection[i] = new Garbage($"Обновление объекта {i}", 50, 4096);
                }
                else
                {
                    largeCollection[i] = null;
                }
            }
            sw.Stop();

            Console.WriteLine($"Время обнолвения: {sw.ElapsedMilliseconds} мс");

            largeCollection.Clear();
            GC.Collect();

            int gcCountAfter = GC.CollectionCount(0);
            long memoryAfterGC = GC.GetTotalMemory(true);

            Console.WriteLine($"Всего сборок мусора Gen 0: {gcCountAfter - gcCountBefore}");
            Console.WriteLine($"Память после очистки: {memoryAfterGC} байт");
        }

        public static void TestCollectionWithChanges()
        {
            Console.WriteLine("\nКоллекция");

            List<Garbage> dynamicCollection = new List<Garbage>();
            Random random = new Random();

            long initialMemory = GC.GetTotalMemory(false);
            int initialGC = GC.CollectionCount(0);

            Stopwatch sw = Stopwatch.StartNew();

            for (int operation = 0; operation < 1000; operation++)
            {
                int action = random.Next(0, 3);

                switch (action)
                {
                    case 0:
                        dynamicCollection.Add(new Garbage(
                            $"{operation}",
                            random.Next(1, 100),
                            random.Next(256, 4096)
                        ));
                        break;

                    case 1:
                        if (dynamicCollection.Count > 0)
                        {
                            int index = random.Next(0, dynamicCollection.Count);
                            dynamicCollection[index] = new Garbage(
                                $"{operation}",
                                random.Next(1, 50),
                                random.Next(512, 2048)
                            );
                        }
                        break;

                    case 2:
                        if (dynamicCollection.Count > 0)
                        {
                            int index = random.Next(0, dynamicCollection.Count);
                            dynamicCollection[index] = null;
                        }
                        break;
                }

                if (operation % 100 == 0)
                {
                    GC.Collect(0, GCCollectionMode.Optimized);
                }
            }

            sw.Stop();

            dynamicCollection.Clear();
            GC.Collect();

            long finalMemory = GC.GetTotalMemory(true);
            int finalGC = GC.CollectionCount(0);

            Console.WriteLine($"Время работы: {sw.ElapsedMilliseconds} мс");
            Console.WriteLine($"Сборок мусора Gen 0: {finalGC - initialGC}");
            Console.WriteLine($"Итоговое использование памяти: {finalMemory - initialMemory} байт");
        }

        public static void PrintGCStats()
        {
            Console.WriteLine("\nСборщик мусора");
            Console.WriteLine($"Коллекция Gen 0: {GC.CollectionCount(0)}");
            Console.WriteLine($"Коллекция Gen 1: {GC.CollectionCount(1)}");
            Console.WriteLine($"Коллекция Gen 2: {GC.CollectionCount(2)}");
            Console.WriteLine($"Общая память {GC.GetTotalMemory(false)} байт");

            GCLatencyMode mode = GCSettings.LatencyMode;
            Console.WriteLine(mode);

            bool isServerGC = GCSettings.IsServerGC;
            Console.WriteLine(isServerGC);
        }
    }
}
