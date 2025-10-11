namespace _02._04_Delegates
{
    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            List<string> strings = new() {"Имя", "!Имя", "&Имя", "***ТЕКСТ****", "Текст", "Да"};

            var res = strings.Filter(n => !n.Any(ch => !char.IsLetterOrDigit(ch)));

            Console.WriteLine(string.Join(", ", res));
        }
	}

	public static class ListExtension
	{
		public static List<TSource> Filter<TSource>(this List<TSource> data, Predicate<TSource> delegat)
		{
			var result = new List<TSource>();
			foreach (TSource x in data)
			{
				if (delegat(x))
					result.Add(x);
			}
			return result;
		}
	}
}
