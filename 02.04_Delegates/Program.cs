using Microsoft.VisualBasic;

namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(int x);
    public delegate bool FilterStringDelegate(string text);
    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5, };
            var res1 = Filter(numbers, n => n % 2 == 0);
            var res2 = Filter(numbers, n => n > 10);
            List<string> text = new() { "А на море белый п@сок", "Дует теплый ветер в лицо", "Мо#жно даже неба коснуться рукой", "Буду очень оч1&ь скучать" };
            var filteredStrings = FilterStrings(text, NoSymbol);

            foreach (var str in filteredStrings)
                Console.WriteLine(str);

           /// foreach (var r in res2)
              //  Console.Write(r+ " ");
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
        public static List<string> FilterStrings(List<string> data, FilterStringDelegate delegat)
        {
            var result = new List<string>();
            foreach (string d in data)
            {
                if (delegat(d))
                    result.Add(d);
            }
            return result;
        }
        public static bool NoSymbol(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return false; 
                }
            }
            return true; 
        }


    }  /// !да это нет
}
