namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor expressProcessor = new OrderProcessor(new ExpressDeliveryFactory(), 100);
            OrderProcessor economProcessor = new OrderProcessor(new EconomDeliveryFactory(), 100);

            Console.WriteLine(expressProcessor);
            Console.WriteLine(economProcessor);
        }
    }
}
