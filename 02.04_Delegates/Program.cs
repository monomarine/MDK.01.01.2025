namespace _02._04_Delegates
{
    public delegate bool FilterDelegate(string x);
    
    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            //List<int> numbers = new() { 4, 8, 2, 8, 5, 98, 8, 5, };
            //var res1 = Filter(numbers, n => n % 2 == 0);
            //var res2 = Filter(numbers, n => n > 10);

            List<string> text = new() { "one", "two", "alisa", "b@#$ook", "pig5" };
            var res3 = Filter(text, ttext =>
            {
                foreach (var r in ttext)
                {
                    if (!char.IsLetterOrDigit(r))
                    return false;
                }
                return true;
            } 
            );

            foreach (var r in res3)
            {
                Console.Write(r + " ");
            }
        } 

        public static List<string> Filter(List<string> data, FilterDelegate delegat)
        {
            var result = new List<string>();
            foreach (string d in data)
            {
                if (delegat(d)) result.Add(d);
            }
            return result;
        }
    }
}
