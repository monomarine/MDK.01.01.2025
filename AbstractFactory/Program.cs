namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------Эконом доставка-------");
            OrderProcessor economyOrder = new OrderProcessor(new EconomyDeliveryFactory());
            Console.WriteLine(economyOrder.OrderProcess(1500));
        }
    }
}
