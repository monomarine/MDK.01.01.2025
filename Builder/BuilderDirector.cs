using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetAppirance("обыччный воин из деревни")
                .AddSkill("сильный удар")
                .AddSkill("быбстрый бег")
                .SetClass(CharacterClass.Warrior);
        }

        public ICharacterBuilder CreateCustomCharacter(string name, int level, int strenght, int mana, CharacterClass characterClass, string weaponName, string armorName, string helmetName, string bootName)
        {
            return _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetClass(characterClass)
                .SetIntelligence(10)
                .SetMana(mana)
                .SetStrenght(strenght)
                .AddSkill("огненный взрыв")
                .AddSkill("ярость")
                .Weapon(weaponName)
                .Armor(armorName)
                .Helmet(helmetName)
                .Boots(bootName);

        }

        public ICharacterBuilder CreateNPC(string name, CharacterClass npcClass, string role)
        {
            return _characterBuilder.SetName(name)
                .SetClass(npcClass)  
                .SetLevel(3)
                .SetAppirance(role)
                .AddSkill("Базовый навык оружия")
                .Weapon("Простое оружие")
                .Armor("Простая броня")
                .Boots("Простые сапоги")
                .AddAccessories("Нет");
        }
    }
}
