namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(char x);
    internal class Program
    {
        protected static List<char> chars = new() { '@', '#', '$', '%', '&', '№' };
        // переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        // те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            //List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5, };
            //var res1 = Filter(numbers, n => n % 2 == 0);
            //var res2 = Filter(numbers, n => n > 10);
            List<string> strs = new List<string>() { "lksjdflksd", "lksjdfkldj@sldkfsdl;kfs", "1234567"};
            List<string> res = Filter(strs, n => chars.Contains(n));
            foreach(var r in res)
                Console.WriteLine(r);
        } 

        public static List<String> Filter(List<string> data, FilterDelegate delegat)
        {
            var result = new List<string>();
            foreach (string d in data)
            {
                bool f = false;
                foreach (var c in d.ToCharArray()) {
                    if (delegat(c))
                    {
                        f = true; break;
                    }
                }
                if (!f) result.Add(d);
            }
            return result;
        }
    }
}
