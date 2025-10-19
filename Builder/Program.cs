namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Тестирование Паттерна Строитель ---");
            Console.WriteLine();

            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            Console.WriteLine("Сборка Воина:");
            GameCharacter warrior = (GameCharacter)director.CreateWarrior("Конан", 10);
            warrior.Display();

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Сборка NPC (Стражника):");
            GameCharacter guardNPC = director.CreateNPCGuard("Стражник Том", 5);
            guardNPC.Display();

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Сборка Мага с ручной экипировкой:");

            GameCharacter customMage = builder.SetName("Гэндальф")
                .SetLevel(20)
                .SetClass(CharacterClass.Mage)
                .SetStats()
                .SetAppirance("Мудрый старец с длинной бородой")
                .AddSkill("Посоховый удар")
                .SetWeapon("Посох Света")
                .SetArmor("Мантия")
                .AddAccessory("Кольцо Всевластия")
                .SetHealth(500)
                .SetMana(1000)
                .SetIntelligence(10)
                .SetStrenght(1)
                .SetDexterity(5)
                .AddAccessory("Трава 'Трубка'")
                .SetHelmet("Шляпа Волшебника")
                .SetBoots("Сандалии")
                .GetResult();

            customMage.Display();

            Console.WriteLine("--- Тестирование завершено ---");
            Console.ReadKey();
        }
    }
}