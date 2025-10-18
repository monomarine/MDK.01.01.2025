using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Экспресс доставка ===");
            OrderProcessor expressOrder = new OrderProcessor(new ExpressDeliveryFactory());
            Console.WriteLine(expressOrder.OrderProcess(1500));

            Console.WriteLine("\n=== Эконом доставка ===");
            OrderProcessor economyOrder = new OrderProcessor(new EconomyDeliveryFactory());
            Console.WriteLine(economyOrder.OrderProcess(1500));

            Console.ReadKey();
        }
    }
}
