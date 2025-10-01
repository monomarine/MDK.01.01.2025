namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1122, 20000);
            Account.AnnualInterestRate = 4.5;

            account.Withdraw(2500);
            account.Deposit(3000);

            Console.WriteLine($"Баланс: {account.Balance} руб.");
            Console.WriteLine($"Ежемесячные проценты: {account.GetMonthlyInterest()} руб.");
            Console.WriteLine($"Дата создания счета: {account.DateCreated}");
            ISave save = new Save();

            try
            {
                save.Unlock();
                save.AddMoney(10000);

                Console.WriteLine(save);

                save.Lock();
                save.DecMoney(1000);
                
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(save);

        }
    }
}