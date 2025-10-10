namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(string x);

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new()
            {"egor#", "buglak", "lol", "artem$", "golovnik", "kek"};

            var res1 = Filter(strings, s => !FindSpecChar(s));
            var res2 = Filter(strings, s => FindDefaultString(s));

            Console.WriteLine("Строки без специальных символов:");
            foreach (var r in res1)
                Console.WriteLine(r);
        }

        public static List<string> Filter(List<string> data, FilterDelegate delegat)
        {
            var result = new List<string>();
            foreach (string d in data)
            {
                if (delegat(d))
                    result.Add(d);
            }
            return result;
        }
        public static bool FindSpecChar(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool FindDefaultString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}