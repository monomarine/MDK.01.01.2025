namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй, странник!");

            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            var warriorBuilder = director.CreateWarrior("воин", 5)
                .SetWeapon("меч")
                .SetArmor("кольчуга")
                .SetHelmet("шлем");

            var warrior = builder.Reset();
            warrior.Display();

            var npcBuilder = director.CreateNPC("торговец", "продавец");
            var npc = builder.Reset();
            npc.Display();
        }
    }
}