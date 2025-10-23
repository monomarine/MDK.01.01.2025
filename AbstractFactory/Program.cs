using AbstractFactory.Economy;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ExpressDeliveryFactory());
            OrderProcessor economyProcessor = new OrderProcessor(new EconomyDeliveryFactory());

            Console.WriteLine(orderProcessor.OrderProcess(1500));
            Console.WriteLine(economyProcessor.OrderProcess(200));
        }
    }
}
