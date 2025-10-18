namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ExpressDeliveryFactory());

            Console.WriteLine(orderProcessor.OrderProcess(1500));
        }
    }
}
