namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            var warrior = director.CreateWarrior("Алёша", 5).Build();

            var npc = director.CreateNPC("Федод").Build();

            var mage = director.CreateCustomCharacter("Мерлин", 10, 5, 100, CharacterClass.Mage).Build();

            warrior.Display();
            npc.Display();
            mage.Display();
        }
    }
}
