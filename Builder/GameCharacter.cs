using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public enum CharacterClass { Warrior, Mage, Archer, Rogue, Priest }
    internal class GameCharacter
    {
        public string Name { get; set; }
        public CharacterClass Class { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public List<string> Skills { get; set; }
        public Equipment Equipment { get; set; }
        public string Appearance { get; set; }

        public GameCharacter()
        {
            Skills = new List<string>();
            Equipment = new Equipment();
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ИГРОВОЙ ПЕРСОНАЖ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Класс: {Class}");
            Console.WriteLine($"Уровень: {Level}");
            Console.WriteLine($"Здоровье: {Health}");
            Console.WriteLine($"Мана: {Mana}");
            Console.WriteLine($"Сила: {Strength}");
            Console.WriteLine($"Ловкость: {Dexterity}");
            Console.WriteLine($"Интеллект: {Intelligence}");
            Console.WriteLine($"Навыки: {string.Join(", ", Skills)}");
            Console.WriteLine($"Внешность: {Appearance}");
            Console.WriteLine("Экипировка:");
            Equipment.Display();
            Console.WriteLine();
        }

    }
}
