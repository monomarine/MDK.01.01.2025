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
                .SetAppirance("Обычный воин из деревни")
                .AddSkill("Сильный удар")
                .AddSkill("Быстрый бег")
                .SetClass(CharacterClass.Warrior)
                .SetEquipment(equipment => equipment
                .SetWeapon("Деревянный меч")
                .SetArmor("Нет")
                .SetHelmet("Шапка мономах")
                .SetBoots("Кожаные сапоги")
                .AddAccessory("Икона"));

        }

        public ICharacterBuilder CreateCustomCharacter(string name, int level, int strenght, int mana, CharacterClass characterClass)
        {
            return _characterBuilder.SetName(name)
                .SetLevel(level)
                .SetClass(characterClass)
                .SetIntelligence(10)
                .SetMana(mana)
                .SetStrenght(strenght)
                .AddSkill("Огненный взрыв")
                .AddSkill("Ярость")
                .SetEquipment(equipment => equipment
                .SetWeapon("Посох мага")
                .SetArmor("Шляпа лягушки")
                .SetHelmet("Нет")
                .SetBoots("Шелковые черевички")
                .AddAccessory("Кольцо 4 королевств"));


        }

        public ICharacterBuilder CreateNPC(string name)
        {
            return _characterBuilder.SetName(name)
                .SetAppirance($"Стандартная внешность")
                .AddSkill("Знание местности")
                .AddSkill("Болтовня")
                .SetEquipment(equipment => equipment
                .SetArmor("Простая одежда")
                .SetHelmet("Нет")
                .SetBoots("Рваные ботинки")
                .AddAccessory("Нет"));
        }
    }
}
