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

        public ICharacterBuilder CreateCustomCharacter(string name, int level, int strenght, int mana, CharacterClass characterClass)
        {
            return _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetClass(characterClass)
                .SetIntelligence(10)
                .SetMana(mana)
                .SetStrenght(strenght)
                .AddSkill("огненный взрыв")
                .AddSkill("ярость");

        }

        public ICharacterBuilder CreateNPC(string name, int level, CharacterClass characterClass, Equipment equipment = null)
        {
            var builder = _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetClass(characterClass)
                .SetAppirance("Житель деревни")
                .AddSkill("Торговля")
                .AddSkill("Разговор");

            if (equipment != null)
            {
                builder.SetEquipment(equipment);
            }
            else
            {
                builder.SetWeapon("Посох")
                       .SetArmor("Простая одёжка")
                       .SetHelmet("-")
                       .SetBoots("Лапти")
                       .AddAccessory("-");
            }

            return builder;
        }
    }
}
