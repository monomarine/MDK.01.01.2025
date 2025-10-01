namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1911, 1000.0);

            Console.WriteLine("Начальное состояние:");
            Console.WriteLine(account);
            Console.WriteLine();
            Console.WriteLine("Пополнение:");
            account.AddMoney(500);
            Console.WriteLine(account);
            Console.WriteLine();

            Console.WriteLine("Снятие:");
            int withdrawn = account.DecMoney(200);
            Console.WriteLine($"Снято: {withdrawn} руб.");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.WriteLine("Блокировка счета:");
            account.Lock();
            Console.WriteLine(account);
            Console.WriteLine();

            Console.WriteLine("Попытка операции с заблокированным счетом:");
            try
            {
                account.AddMoney(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
