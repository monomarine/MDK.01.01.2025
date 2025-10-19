namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuilderDirector director = new BuilderDirector();
            GameCharacter warrior = director.BuildWarrior("Воин");
            GameCharacter npc = director.BuildNPC("Стандартный НПС");
            GameCharacter custom = director.BuildCustomCharacter("Персонаж", 10, CharacterClass.Priest, armor: "Мантия", boots: "Кожаные ботинки", weapon: "Посох");
            List<GameCharacter> list = new List<GameCharacter>() { warrior, npc, custom};
            
            foreach (GameCharacter c in list)
            {
                c.Display();
            }
        }
    }
}
