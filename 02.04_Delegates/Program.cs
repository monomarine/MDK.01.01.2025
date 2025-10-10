namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(int x);
    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5, };
            var res1 = Filter(numbers, n => n % 2 == 0);
            var res2 = Filter(numbers, n => n > 10);


            foreach(var r in res2)
                Console.Write(r+ " ");
        } 

        public static List<int> Filter(List<int> data, FilterDelegate delegat)
        {
            var result = new List<int>();
            foreach (int d in data)
            {
                if (delegat(d))
                    result.Add(d);
            }
            return result;
        }
    }
}
