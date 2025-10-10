namespace GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false).ToString());
            Console.WriteLine();

            var accountList = new List<Account>();
            for (int i = 0; i < 10; i++) accountList.Add(new Account());
            Console.WriteLine();
            Console.WriteLine(GC.GetTotalMemory(false).ToString());
            Console.WriteLine();
            foreach (var ac in accountList) Console.WriteLine(ac.ToString());
            //accountList[5] = new Account();
            //foreach (var ac in accountList)
            //{
            //    Console.WriteLine(ac.ToString());
            //}
            Console.WriteLine(GC.GetTotalMemory(false).ToString());
        }
    }
}
