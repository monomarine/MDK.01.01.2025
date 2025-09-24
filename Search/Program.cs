namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int maxValue = 100;
                int key = 100;
                int[] array = GetArray(100, maxValue);
                Array.Sort(array);
                Console.WriteLine("Линейный: " + Search.LinearSearch(key, array));
                Console.WriteLine("Итеративный: " + Search.IterativeBinarySearch(key, array));
                Console.WriteLine("Интерполяционный: " + Search.InterpolateSearch(key, array));
                Console.WriteLine(new string('=', 20));
                Console.ReadKey();
            }
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
            return array;
        }
       
    }
}
