namespace _02._02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
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