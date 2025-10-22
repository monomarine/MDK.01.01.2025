namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            // кастомный перс
            Console.WriteLine("КАСТОМНЫЙ ПЕРСОНАЖ:");
            director.CreateCustomCharacter(
                "Джайна Праудмур",
                25,
                12,
                300,
                CharacterClass.Mage,
                "Посох архимага",
                "Мантия верховного чародея",
                "Корона Даларана",
                "Сапоги магического потока"
            ).SetStats()
             .AddSkill("Ледяная буря")
             .AddSkill("Телепортация")
             .SetAppirance("Могущественная чародейка")
             .Validate();

            var resultCustom = builder.Reset();
            resultCustom.Display();

            // nps
            Console.WriteLine("NPC:");
            var builder2 = new CharacterBuilder();  
            var director2 = new BuilderDirector(builder2);

            director2.CreateNPC(
                "Бугай",
                CharacterClass.Warrior,
                "Воин Орды"
            ).SetStats();

            var resultNPC = builder2.Reset();
            resultNPC.Display();

            Console.ReadLine();
        }
    }
}
