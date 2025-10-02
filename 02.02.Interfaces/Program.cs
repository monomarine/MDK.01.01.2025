namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISave account = new Account("12345");

            try
            {
                account.Unlock();
                account.AddMoney(5000);

                Console.WriteLine(account);

                account.DecMoney(1500);
                Console.WriteLine(account);

                account.Lock();
                account.DecMoney(500); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine(account);
        }
    }
}