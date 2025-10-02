namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISave save = new Save();
            ISave a = new BankAccount();
            Console.WriteLine(a);
            ISave a2 = new BankAccount(1122, 20000, 4.5);
            a2.DecMoney(2500);
            Console.WriteLine(a2.Summ);
            a2.AddMoney(3000);
            Console.WriteLine("\n" + a2.Summ + "\n");
            Console.WriteLine(a2);

            ISave a3 = new BankAccount();
            a3.Lock();
            Console.WriteLine(a3);

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