namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1122, 20000);
            Account.AnnualInterestRate = 4.5f;

            a1.ToString();
            //a1.Unlock();
            Console.WriteLine(a1.DecMoney(2500));

            a1.AddMoney(3000);
            Console.WriteLine();

            a1.ToString();
        }
    }
}
