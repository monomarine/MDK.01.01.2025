namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            builder = (CharacterBuilder)director.CreateWarrior("Грог", 10).SetStats();
            var warrior = builder.GetCharacter();
            warrior.Display();

            builder = (CharacterBuilder)director.CreateCustomCharacter("Алистер", 20, 8, 150, CharacterClass.Mage)
                .SetWeapon("Посох мага")
                .SetArmor("Мантия мудрости")
                .AddAccessory("Амулет огня")
                .SetStats();
            var mage = builder.GetCharacter();
            mage.Display();

            builder = (CharacterBuilder)director.CreateNPC("Торговец Артур", "приятный мужчина средних лет");
            var npc = builder.GetCharacter();
            npc.Display();


            Console.ReadKey();
        }
    }
}
