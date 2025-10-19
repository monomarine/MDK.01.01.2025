namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 1500; // расстояние для заказа 

            Console.WriteLine("=== ТЕСТИРОВАНИЕ ЭКСПРЕСС-ДОСТАВКИ ===");
            OrderProcessor expressProcessor = new OrderProcessor(new ExpressDeliveryFactory());
            Console.WriteLine(expressProcessor.OrderProcess(distance));

            Console.WriteLine("\n====================================\n");
            Console.WriteLine("=== ТЕСТИРОВАНИЕ ЭКОНОМ-ДОСТАВКИ ===");
            OrderProcessor economyProcessor = new OrderProcessor(new EconomyDeliveryFactory());
            Console.WriteLine(economyProcessor.OrderProcess(distance));
        }
    }
}
