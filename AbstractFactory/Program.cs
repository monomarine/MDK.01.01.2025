namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ExpressDeliveryFactory());

            Console.WriteLine(orderProcessor.OrderProcess(1500));

            OrderProcessor economyOrder = new OrderProcessor(new EconomyDeliveryFactory());

            Console.WriteLine(economyOrder.OrderProcess(1500));
        }
    }
}
