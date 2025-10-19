namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ExpressDeliveryFactory());

            Console.WriteLine(orderProcessor.OrderProcess(1500));

            Console.WriteLine("\n=== ЭКОНОМ ДОСТАВКА ===");
            OrderProcessor economOrder = new OrderProcessor(new EconomDeliveryFactory());
            Console.WriteLine(economOrder.OrderProcess(1500));
        }
    }
}
