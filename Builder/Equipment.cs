using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Equipment
    {
        public string Weapon { get; set; } = "Нет";
        public string Armor { get; set; } = "Нет";
        public string Helmet { get; set; } = "Нет";
        public string Boots { get; set; } = "Нет";
        public List<string> Accessories { get; set; }

        public Equipment()
        {
            Accessories = new List<string>();
        }

        public void Display()
        {
            Console.WriteLine($"  Оружие: {Weapon}");
            Console.WriteLine($"  Броня: {Armor}");
            Console.WriteLine($"  Шлем: {Helmet}");
            Console.WriteLine($"  Обувь: {Boots}");
            Console.WriteLine($"  Аксессуары: {string.Join(", ", Accessories)}");
        }
    }
}
