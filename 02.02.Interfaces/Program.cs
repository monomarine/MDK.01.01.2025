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
            
            ISave save2 = new Account();

            try
            {
                save2.Unlock();
                save2.AddMoney(100);

                Console.WriteLine(save2);

                save.Lock();
                save.DecMoney(20);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(save2);
        }
    }
}