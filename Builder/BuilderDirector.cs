namespace Builder
{
    internal class BuilderDirector
    {
        private readonly ICharacterBuilder _characterBuilder;

        public BuilderDirector(ICharacterBuilder builder)
        {
            _characterBuilder = builder;
        }

        public ICharacterBuilder CreateWarrior(string name, int level)
        {
            return _characterBuilder
                .SetName(name)
                .SetLevel(level)
                .SetClass(CharacterClass.Warrior)
                .SetAppirance("Сильный деревенский воин")
                .AddSkill("Мощный удар")
                .AddSkill("Быстрая атака")
                .SetWeapon("Меч")
                .SetArmor("Стальная броня")
                .SetHelmet("Железный шлем")
                .SetBoots("Кожаные сапоги");
        }

        public ICharacterBuilder CreateCustomCharacter(string name, int level, int strenght, int mana, CharacterClass characterClass)
        {
            return _characterBuilder
                .SetName(name)
                .SetLevel(level)
                .SetClass(characterClass)
                .SetStrenght(strenght)
                .SetMana(mana)
                .SetAppirance("Особый герой")
                .AddSkill("Огненный взрыв");
        }

       
        public ICharacterBuilder CreateNPC(string name, string appirance)
        {
            return _characterBuilder
                .SetName(name)
                .SetClass(CharacterClass.Priest)
                .SetLevel(1)
                .SetAppirance(appirance)
                .AddSkill("Исцеление")
                .SetWeapon("Посох")
                .SetArmor("Одеяние")
                .AddAccessory("Амулет света");
        }
    }
}
