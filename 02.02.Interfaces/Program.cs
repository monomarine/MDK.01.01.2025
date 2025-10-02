using System;

namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(1122, 20000);
            Account.AnnualInterestRate = 4.5;

            account.Withdraw(2500);
            account.Deposit(3000);

            Console.WriteLine(account);
            Console.WriteLine($"Ежемесячные проценты: {account.GetMonthlyInterest():F2} руб.");

            var save = new Save();

            try
            {
                save.Unlock();
                save.AddMoney(5000);
                save.DecMoney(2000);
                Console.WriteLine(save);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
