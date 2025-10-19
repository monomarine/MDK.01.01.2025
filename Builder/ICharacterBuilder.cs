using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetClass(CharacterClass characterClass);
        ICharacterBuilder SetLevel(int level);
        ICharacterBuilder SetHealth(int health);
        ICharacterBuilder SetMana(int mana);
        ICharacterBuilder SetStrenght(int strenght);
        ICharacterBuilder SetIntelligence(int intelligance);
        ICharacterBuilder SetDexterity(int dexterity);
        ICharacterBuilder AddSkill(string skillName);
        ICharacterBuilder SetAppirance(string appirance);
        ICharacterBuilder SetStats();
        ICharacterBuilder SetWeapon(string weapon);
        ICharacterBuilder SetArmor(string armor);
        ICharacterBuilder SetHelmet(string helmet);
        ICharacterBuilder SetBoots(string boots);
        ICharacterBuilder AddAccessory(string accessory);
        void Validate();
    }
}
