namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var builderWarior = new BuilderDirector(new CharacterBuilder());
            var builderNPC = new BuilderDirector(new CharacterBuilder());

            var npc = builderNPC.CreaterNPC("Steve");
            var warior = builderWarior.CreateWarrior("Hanson", 12);

            npc.Display();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            warior.SetWeapon("Адаматировый меч");
            warior.SetHelmet("Титановый шлем");
            warior.AddAccessories("Кольцо регенерации");
            warior.AddAccessories("Крылья");
            warior.AddAccessories("Огненные печатки");
            warior.RemoveAccessories("Крылья");
            warior.SetStats();

            warior.Display();
        }
    }
}
