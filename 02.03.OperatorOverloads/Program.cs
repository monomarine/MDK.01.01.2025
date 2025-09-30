namespace _02._03.OperatorOverloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product() { Name = "Клавиатура", Price = 2000 };
            Product p2 = new Product() { Name = "Мышь", Price = 1000 };
            Product p3 = new Product() { Name = "USB флешка", Price= 500 };

            if(p1 > p2)
            {
                Console.WriteLine(p1);
            }
            else
                Console.WriteLine(p2);

            Console.WriteLine($"общая стоимость товаров {p1 + p2}");
        }
    }
}