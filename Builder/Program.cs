using System.IO;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var director = new BuilderDirector();
            var warrior = director.CreateWarrior("Хоши", 10);
            warrior.Display();

            var npc1 = director.CreateNPC("Вероника", CharacterClass.Warrior, "Торговец");
            npc1.Display();

            var npc2 = director.CreateNPC("Арина", CharacterClass.Warrior, "Стражник");
            npc2.Display();

            var npc3 = director.CreateNPC("Айгерина", CharacterClass.Priest, "Целитель");
            npc3.Display();

            var npc4 = director.CreateNPC("Арина", CharacterClass.Warrior, "Кузнец");
            npc4.Display();

            Console.ReadKey();
        }
    }
}
