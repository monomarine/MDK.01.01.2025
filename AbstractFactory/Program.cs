namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ExpressDeliveryFactory());

            Console.WriteLine(orderProcessor.OrderProcess(1500));

            var economyFactory = new EconomyFactory();
            var economyProcessor = new OrderProcessor(economyFactory);

            Console.WriteLine(economyProcessor.OrderProcess(300));
        }
    }
}
