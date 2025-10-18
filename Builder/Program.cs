using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            var warrior = director.CreateWarrior("Рагнар", 10).Reset();
            warrior.Display();

            var npc = director.CreateNPC("Старый жрец", "Мудрый старик с посохом").Reset();
            npc.Display();

            var custom = director.CreateCustomCharacter("Ариэль", 20, 7, 120, CharacterClass.Mage).Reset();
            custom.Display();

            Console.ReadKey();
        }
    }
}
