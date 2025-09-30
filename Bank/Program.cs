namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1122, 20000);
            Account.AnnualInterestRate = 4.5;
            account.Unlock();
            Console.WriteLine(account.DecMoney(2500));
            account.AddMoney(3000);
            Console.WriteLine(account.ToString());
        }
    }
}
