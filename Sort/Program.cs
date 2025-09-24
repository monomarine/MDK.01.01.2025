namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArray(20);
            Console.WriteLine("до сортировки:");

            foreach (int i in array) 
                Console.Write(i+" ");

            Sort.MergeSort(array);

            Console.WriteLine("\nпосле сортировки:");

            foreach (int i in array)
                Console.Write(i + " ");
        }
        static int[] GetArray(int count)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(50);
            }
            return array;
        }
    }
}
