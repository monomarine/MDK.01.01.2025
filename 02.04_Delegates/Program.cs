using System.Security.Cryptography.X509Certificates;

namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(int x);
    public delegate bool FilterStringsDelegate(string text);
    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5, };
            List<string> strings = new() { "user", "admin$", "гость"};
            var res1 = Filter(strings, text =>
            {
                foreach (var r in text)   
                {
                    if (!char.IsLetterOrDigit(r)) 
                    return false;
                }
                return true;
            });

            foreach(var r in res1)
            {
                Console.Write(r+ " ");
            }
            //var res1 = Filter(numbers, n => n % 2 == 0);
            //var res2 = Filter(numbers, n => n > 10);



            //foreach(var r in res2)
            //Console.Write(r+ " ");
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

        public static List<string> Filter(List<string> data, FilterStringsDelegate delegat)
        {
            var resultstrings = new List<string>();
            foreach (string d in data)
            {
                if (delegat(d))
                    resultstrings.Add(d);
            }
            return resultstrings;
        }
    }
}
