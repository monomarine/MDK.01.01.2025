namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ExpressDeliveryFactory());

            Console.WriteLine(orderProcessor.OrderProcess(1500));

            Console.WriteLine("\n------Эконом доставка-------");
            OrderProcessor economyOrder = new OrderProcessor(new EconomDeliveryFactory());
            Console.WriteLine(economyOrder.OrderProcess(1500));
        }
    }
}
