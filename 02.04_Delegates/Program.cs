using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(int x);
    public delegate bool StringFilterDelegate(string s);

    internal class Program
    {
        public static bool HasNoSpecialChars(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            return !Regex.IsMatch(s, @"[^0-9\s\p{L}]");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Фильтрация чисел ---");
            List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5, };
            var res1 = Filter(numbers, n => n % 2 == 0);
            var res2 = Filter(numbers, n => n > 10);

            Console.Write("Числа > 10: ");
            foreach (var r in res2)
                Console.Write(r + " ");
            Console.WriteLine("\n");

            Console.WriteLine("--- Фильтрация строк (без спецсимволов) ---");
            List<string> words = new()
            {
                "Hello World",
                "C# is awesome",
                "VladSyundyukovKrutoy!", 
                "100%", 
                "Безоговорочно", 
                "Символ",
                "OKEI 2025",
                "Тест 1.0",
                "Код 100% рабочий" 
            };

            Console.WriteLine("Исходный список:");
            foreach (var w in words)
                Console.WriteLine($"- \"{w}\"");
            Console.WriteLine();
            var cleanStrings = Filter(words, HasNoSpecialChars);

            Console.WriteLine("Отфильтрованные строки (только буквы, цифры и пробелы):");
            foreach (var r in cleanStrings)
                Console.WriteLine($"- \"{r}\"");
        }

        public static List<string> Filter(List<string> data, StringFilterDelegate delegat)
        {
            var result = new List<string>();
            foreach (string d in data)
            {
                if (delegat(d))
                    result.Add(d);
            }
            return result;
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