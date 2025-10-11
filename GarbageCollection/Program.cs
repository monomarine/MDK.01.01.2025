using System.Diagnostics;

namespace GarbageCollection
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            List<Product> products = new List<Product>();
            Console.WriteLine("[=] Начальный объем памяти: " + GC.GetTotalMemory(false));

            sw.Start();

            for (int i = 0; i < 20;  i++)
            {
                products.Add(GenerateProduct());
            }

            sw.Stop();

            Console.WriteLine($"[=] Сгенерированный список из 20 элементов за {sw.ElapsedTicks} тиков: ");
            Console.WriteLine(string.Join("\n", products));
            Console.WriteLine("[=] Объем памяти до очистки мусора: " + GC.GetTotalMemory(false));

            sw.Restart();
            GC.Collect();
            sw.Stop();

            Console.WriteLine($"[=] Объем памяти после очистки мусора за {sw.ElapsedTicks} тиков: " + GC.GetTotalMemory(false));

            sw.Restart();

            for (int i = 0; i < products.Count; i++) 
            {
                products[i] = null;
            }

            sw.Stop();

            Console.WriteLine($"[=] Объем памяти после разыменовая элементов за {sw.ElapsedTicks} тиков: " + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("[=] Объем памяти после разыменовая элементов после очистки мусора: " + GC.GetTotalMemory(false));

            Console.WriteLine("[+] Создаем 100 новых объектов...");

            sw.Restart();

            for (int i = 0; i < 100;  i++)
            {
                products.Add(GenerateProduct());
            }

            sw.Stop();
            
            Console.WriteLine($"[=] Затраченное время: {sw.ElapsedTicks} тиков Новый объем памяти: {GC.GetTotalMemory(false)}");

            Console.WriteLine("[-] Очищаем мусор...");

            sw.Restart();
            GC.Collect();
            sw.Stop();

            Console.WriteLine($"[=] Затраченное время: {sw.ElapsedTicks} тиков Новый объем памяти: {GC.GetTotalMemory(false)}");
        }
        
        public static Product GenerateProduct()
        {
            Random rand = new Random();
            string[] color = { "Желтый", "Зеленый", "Красный", "Голубой", "Синий" };
            string[] names = {"банан", "огурец", "арбуз", "горох", "помидор"};

            string randName = color[rand.Next(color.Length)] + " " + names[rand.Next(names.Length)];

            return new Product(randName, rand.Next(10, 150));
        }
    }
}