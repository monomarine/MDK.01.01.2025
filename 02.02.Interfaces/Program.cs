namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1122, 20000);
            account.AnnualInterestRate = 4.5;

            account.Withdraw(2500);
            Console.WriteLine($"{account.Balance:F2} руб.");

            account.Deposit(3000);
            Console.WriteLine($"{account.Balance:F2} руб.");

            IPurse purse = account;
            Console.WriteLine($"{purse.Summ} руб.");

            purse.AddMoney(1500);
            Console.WriteLine($"Balance = {account.Balance:F2}, Summ = {account.Summ}");

            int withdrawn = purse.DecMoney(800);
            Console.WriteLine($"снято {withdrawn} руб., Balance = {account.Balance:F2}, Summ = {account.Summ}");

            purse.Summ = 25000;
            Console.WriteLine($"Summ = 25000: Balance = {account.Balance:F2}, Summ = {account.Summ}");

            ISave saveAccount = account;
            Console.WriteLine($"Счет заблокирован: {saveAccount.IsLocked}");

            saveAccount.Lock();
            Console.WriteLine($"Счет заблокирован: {saveAccount.IsLocked}");

            try
            {
                account.Deposit(1000);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            try
            {
                purse.AddMoney(500);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка при AddMoney: {ex.Message}");
            }

            saveAccount.Unlock();
            Console.WriteLine($"Счет заблокирован: {saveAccount.IsLocked}");

            account.Deposit(1000);
            Console.WriteLine($"{account.Balance:F2} руб.");

            Console.WriteLine($"ID счета: {account.Id}");
            Console.WriteLine($"Баланс: {account.Balance:F2} руб.");
            Console.WriteLine($"Summ: {account.Summ} руб.");
            Console.WriteLine($"Ежемесячные проценты: {account.GetMonthlyInterest():F2} руб.");
            Console.WriteLine($"Дата создания счета: {account.DateCreated:dd.MM.yyyy HH:mm:ss}");
        }
    }
}