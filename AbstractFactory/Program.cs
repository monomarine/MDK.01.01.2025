namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ExpressDeliveryFactory());

            Console.WriteLine(orderProcessor.OrderProcess(1500));
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("ExpressDeliveryFactory");
            OrderProcessor expressOrder = new OrderProcessor(new ExpressDeliveryFactory());
            Console.WriteLine(expressOrder.OrderProcess(1500));

            Console.WriteLine("\n\nEconomyDeliveryFactory");
            OrderProcessor economyOrder = new OrderProcessor(new EconomyDeliveryFactory());
            Console.WriteLine(economyOrder.OrderProcess(1500));
        }
    }
}
