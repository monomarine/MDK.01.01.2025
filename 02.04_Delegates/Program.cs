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
            List<string> strings = new()
            {
                "Hello", "World!", "Test@123","Normalniy text", "koreckaaalisa4@.com", "@lirisme","  k", "pupupuuu"
            };

            var res1 = FilterStrings(strings, text =>
            {
                foreach (var r in text)
                {
                    if (!char.IsLetterOrDigit(r) && !char.IsWhiteSpace(r))
                        return false;
                }
                return true;
            });

            Console.WriteLine("Строки без спец символов:");
            foreach (var r in res1)
                Console.WriteLine(r);
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
    }
}