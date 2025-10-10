using System;
using System.Collections.Generic;

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
            List<string> strings = new() { "angelina", "karina", "alisa", "al!sa", "masha", "vasya__pupkin" };

            var res = Filter(strings, text =>
            {
                foreach (char q in text)
                {
                    if (!(char.IsLetterOrDigit(q) || q == ' '))
                        return false;
                }
                return true;
            });

            foreach (var q in res)
                Console.WriteLine(q);
        }

        public static List<int> Filter(List<int> data, FilterDelegate delegat)
        {
            var result = new List<int>();
            foreach (int d in data)
                if (delegat(d))
                    result.Add(d);
            return result;
        }

        public static List<string> Filter(List<string> data, FilterStringDelegate delegat)
        {
            var result = new List<string>();
            foreach (string s in data)
                if (delegat(s))
                    result.Add(s);
            return result;
        }
    }
}
