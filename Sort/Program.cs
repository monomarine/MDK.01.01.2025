using System.Diagnostics;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Stopwatch timer = new Stopwatch();


            int[] OriginalArray = GetArray(100);

            int[] array = GetArray(10000);
            Console.WriteLine("до сортировки:");


            int[] array1 = (int[])OriginalArray.Clone();
            timer.Restart();
            timer.Start();
            Console.WriteLine("\nКоличество шагов сортировки bubble:" + Sort.BubbleSort(ref array1));
            timer.Stop();
            Console.WriteLine("Длительность сортировки:" + timer.ElapsedTicks);
            Console.WriteLine();

            int[] array2 = (int[])OriginalArray.Clone();
            timer.Restart();
            timer.Start();
            Console.WriteLine("\nКоличество шагов сортировки Insertion:" + Sort.InsertionSort(ref array2));
            timer.Stop();
            Console.WriteLine("Длительность сортировки:" + timer.ElapsedTicks);
            Console.WriteLine();

            int[] array3 = (int[])OriginalArray.Clone();
            timer.Restart();
            timer.Start();
            Console.WriteLine("\nКоличество шагов сортировки Selection:" + Sort.SelectionSort(ref array3));
            timer.Stop();
            Console.WriteLine("Длительность сортировки:" + timer.ElapsedTicks);
            Console.WriteLine();

            int[] array4 = (int[])OriginalArray.Clone();
            timer.Restart();
            timer.Start();
            Console.WriteLine("\nКоличество шагов сортировки Quick:" + Sort.QuickSort(array4));
            timer.Stop();
            Console.WriteLine("Длительность сортировки:" + timer.ElapsedTicks);
            Console.WriteLine();

            int[] array5 = (int[])OriginalArray.Clone();
            timer.Restart();
            timer.Start();
            Console.WriteLine("\nКоличество шагов сортировки Merge:" + Sort.MergeSort(array5));
            timer.Stop();
            Console.WriteLine("Длительность сортировки:" + timer.ElapsedTicks);
            Console.WriteLine();
        }
        static int[] GetArray(int count)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next();
            }
            return array;
        }
    }
}
