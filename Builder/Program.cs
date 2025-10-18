namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var charBuilder = new CharacterBuilder();
            var director = new BuilderDirector(charBuilder);

            director.CreateWarrior("Боромир", 5)
                    .SetStats();

            try
            {
                charBuilder.Validate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка валидации воина: " + ex.Message);
            }

            var warrior = charBuilder.Reset(); 
            warrior.Display();

            director.CreateCustomCharacter("Эльдора", 8, strenght: 6, mana: 40, characterClass: CharacterClass.Mage)
                    .SetStats();
            try
            {
                charBuilder.Validate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка валидации кастомного: " + ex.Message);
            }
            var custom = charBuilder.Reset();
            custom.Display();

            var npcEquipment = new Equipment
            {
                Weapon = "Короткий меч",
                Armor = "Кожаный жилет",
                Helmet = "Шлем из кожи",
                Boots = "Боевые сапоги"
            };
            npcEquipment.Accessories.Add("Кольцо");
            npcEquipment.Accessories.Add("Медальон");

            director.CreateNPC("Торговец Джек", 2, CharacterClass.Rogue, npcEquipment)
                    .SetStats();

            try
            {
                charBuilder.Validate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка валидации NPC: " + ex.Message);
            }

            var npc = charBuilder.Reset();
            npc.Display();

        }
    }
}
