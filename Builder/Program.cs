namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            director.CreateWarrior("Артур", 5)
                .SetBoots("железные сапоги")
                .AddAccessory("печать");

            var warrior = builder.Reset();
            warrior.Display();
            
            director.CreateCustomCharacter("Мерлин", 10, 8, 100, CharacterClass.Mage)
                .SetHelmet("капюшон")
                .SetBoots("шелковые сапоги")
                .AddAccessory("кольцо")
                .AddAccessory("оберег");

            var mage = builder.Reset();
            mage.Display();

            director.CreateNPC("Бродяга", "человек")
                .AddSkill("убеждение")
                .AddAccessory("веревка")
                .AddAccessory("кошелк");

            var npc = builder.Reset();
            npc.Display();

            var customCharacter = builder
                .SetName("Миру")
                .SetClass(CharacterClass.Archer)
                .SetLevel(7)
                .SetAppirance("эльф-следопыт")
                .AddSkill("меткая стрельба")
                .AddSkill("скрытность")
                .SetWeapon("лук")
                .SetArmor("кожаная броня")
                .SetHelmet("капюшон")
                .SetBoots("сапоги")
                .AddAccessory("колчан")
                .AddAccessory("амулет");

            builder.Validate();
            var archer = builder.Reset();
            archer.Display();
        }
    }
}
