namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISave save = new Account();

            save.Unlock();

            save.AddMoney(100);

            save.Lock();

            Console.WriteLine(save);

            try
            {
                save.DecMoney(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(save);
        }
    }
}