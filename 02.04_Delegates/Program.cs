namespace _02._04_Delegates
{
    //public delegate bool FilterDelegate(int x);
    public delegate bool FilterStringDelegate(string text);

    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5 };
            //var res1 = Filter(numbers, n => n % 2 == 0);
            //var res2 = Filter(numbers, n => n > 10);

            List<string> strings = new()
            {
                "Serega", "Maksim!", "Artemkotik@@@", "IgorRuzaki", "qwe---rty", "@Chernev", "qqqqq", "zxcvb"
            };

            var filteredStrings = FilterStrings(strings, text =>
            {
                foreach (var r in text)
                {
                    if (!char.IsLetterOrDigit(r) && !char.IsWhiteSpace(r))
                        return false;
                }
                return true;
            });

            //Console.WriteLine("Числа больше 10:");
            //foreach (var r in res2)
            //    Console.Write(r + " ");

            Console.WriteLine("Строки без спец символов:");
            foreach (var r in filteredStrings)
                Console.WriteLine(r);
        }

        //public static List<int> Filter(List<int> data, FilterDelegate delegat)
        //{
        //    var result = new List<int>();
        //    foreach (int d in data)
        //    {
        //        if (delegat(d))
        //            result.Add(d);
        //    }
        //    return result;
        //}

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