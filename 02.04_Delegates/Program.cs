using System.Security.Cryptography.X509Certificates;

namespace _02._04_Delegates
{
    public delegate bool FilterDelegate<T>(T x);

    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            List<string> strings = new() {"Имя", "!Имя", "&Имя", "***ТЕКСТ****", "Текст", "Да"};

            var res = Filter<string>(strings, n => !n.Any(ch => !char.IsLetterOrDigit(ch)));

            Console.WriteLine(string.Join(", ", res));
        }

		public static List<T> Filter<T>(List<T> data, FilterDelegate<T> delegat)
		{
			var result = new List<T>();
			foreach (T x in data)
			{
				if (delegat(x))
					result.Add(x);
			}
			return result;
		}
	}