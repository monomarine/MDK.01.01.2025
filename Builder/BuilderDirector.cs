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

        public GameCharacter CreateWarrior(string name, int level)
        {
            _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetAppirance("обыччный воин из деревни")
                .AddSkill("сильный удар")
                .AddSkill("быстрый бег")
                .SetClass(CharacterClass.Warrior)
                .SetStats(); 

            _characterBuilder.Validate();
            return _characterBuilder.GetResult();

        }

        public GameCharacter CreateCustomCharacter(string name, int level, int strenght, int mana, CharacterClass characterClass)
        {
            _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetClass(characterClass)
                .SetIntelligence(10)
                .SetMana(mana)
                .SetStrenght(strenght)
                .AddSkill("огненный взрыв")
                .AddSkill("ярость")
                .SetStats();

            _characterBuilder.Validate();

            return _characterBuilder.GetResult();
        }
        public GameCharacter CreateNPCGuard(string name, int level)
        {
            _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetClass(CharacterClass.Warrior)
                .SetAppirance("Крепкий, суровый стражник в полном доспехе")
                .AddSkill("Остановить и обыскать")
                .AddSkill("Удар щитом")
                .SetWeapon("Длинный меч стражника")
                .SetArmor("Кольчужный доспех")
                .SetHelmet("Стальной шлем")
                .SetBoots("Тяжелые сапоги")
                .AddAccessory("Городской герб")
                .SetStats();

            _characterBuilder.Validate();
            return _characterBuilder.GetResult();
        }
    }
}


