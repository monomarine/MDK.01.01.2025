using System.Security.Principal;

namespace BankI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();

            account1.Id = 1122;
            account1.balance = 20000;
            account1.annualInterestRate = 4.5;

            Console.WriteLine("Изначальный счет:");
            account1.ShowInfo();

            account1.AddMoney(7800);
            Console.WriteLine($"После пополнения: {account1.balance}");

            account1.DecMoney(530);
            Console.WriteLine($"После снятия: {account1.balance}");

            account1.Lock();
            Console.WriteLine("\nСчет заблокирован!");

            try
            {
                account1.AddMoney(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            account1.Unlock();
            account1.AddMoney(500);
            Console.WriteLine($"\nПосле разблокировки: {account1.balance}");

            Console.WriteLine("\nИтоговый счет:");
            account1.ShowInfo();
        }
    }
}
