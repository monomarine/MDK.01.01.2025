using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class BuilderDirector
    {
        public GameCharacter BuildWarrior(string name)
        {
            CharacterBuilder characterBuilder = new CharacterBuilder();
            characterBuilder.Setup(name, CharacterClass.Warrior)
                .SetArmor("Железная броня")
                .SetHelmet("Железный шлем")
                .SetBoots("Железные ботинки")
                .SetWeapon("Железный меч")
                .AddSkill("Сильный удар");
            return characterBuilder.Build();
        }

        public GameCharacter BuildCustomCharacter(string name, int level, CharacterClass characterClass, string armor = "Нет", string helmet = "Нет", string boots = "Нет", string weapon = "Нет")
        {
            CharacterBuilder characterBuilder = new CharacterBuilder();
            characterBuilder.Setup(name, characterClass)
                .SetLevel(level)
                .SetArmor(armor)
                .SetHelmet(helmet)
                .SetBoots(boots)
                .SetWeapon(weapon);
            return characterBuilder.Build();
        }

        public GameCharacter BuildNPC(string name)
        {
            CharacterBuilder characterBuilder = new CharacterBuilder();
            characterBuilder.Setup(name, CharacterClass.NPC)
                .SetLevel(0)
                .SetAppearance("Житель")
                .AddSkill("Разговор");
            return characterBuilder.Build();
        }

    }
}
