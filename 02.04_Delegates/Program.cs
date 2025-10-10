namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(int x);
    public delegate bool Delegate(string x);
    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5, };
            var res1 = Filter(numbers, n => n % 2 == 0);
            var res2 = Filter(numbers, n => n > 10);


            foreach (var r in res2)
                Console.Write(r + " ");

            List<string> str = new() { "eset", "utyapov", "t.tt", "hello world", "test@123", "normal_string" };
            var res3 = Filter2(str, s => !s.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)));
            Console.WriteLine("Строки без специальных символов:");
            foreach (var r in res3)
                Console.Write(r + " ");
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

        public static List<string> Filter2(List<string> data, Delegate delegat)
        {
            var result = new List<string>();
            foreach (string d in data)
            {
                if (delegat(d))
                    result.Add(d);
            }
            return result;
        }
    }
}