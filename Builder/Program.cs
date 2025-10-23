namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            Console.WriteLine("Новый персонаж:");
            director.CreateCustomCharacter(
                "Барин Викторов",
                10,
                30,
                0,
                CharacterClass.Warrior,
                "Нож в рыбе",
                "Бронированный поварской фартук",
                "Усиленная поварская шапка",
                "Туфли с металлическими вставками"
            ).SetStats()
             .AddSkill("Помощь Нагия Дмитриева")
             .AddSkill("Метание ножа")
             .SetAppirance("Усатый крепко сбитый повар")
             .Validate();

            var resultCustom = builder.Reset();
            resultCustom.Display();

            Console.WriteLine("NPC:");
            var builder2 = new CharacterBuilder();  
            var director2 = new BuilderDirector(builder2);

            director2.CreateNPC(
                "Нагий Дмитриев",
                CharacterClass.Warrior,
                "Управляющий рестораном"
            ).SetStats();

            var resultNPC = builder2.Reset();
            resultNPC.Display();

            Console.ReadLine();
        }
    }
}
