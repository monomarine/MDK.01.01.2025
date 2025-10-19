using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface ICharacterBuilder
    {
        public ICharacterBuilder SetStrength(int value);
        public ICharacterBuilder SetIntelligence(int value);
        public ICharacterBuilder SetDexterity(int value);
        public ICharacterBuilder SetMana(int value);
        public ICharacterBuilder SetHealth(int value);
        public ICharacterBuilder SetLevel(int value);
        public ICharacterBuilder SetAppearance(string appearance);
        public ICharacterBuilder AddSkill(string skill);
        public ICharacterBuilder SetArmor(string value);
        public ICharacterBuilder SetHelmet(string value);
        public ICharacterBuilder SetBoots(string value);
        public ICharacterBuilder SetWeapon(string value);
        public ICharacterBuilder AddAccessory(string value);
        public ICharacterBuilder Setup(string name, CharacterClass characterClass);
        public GameCharacter Build();
        public bool Validate();
    }
}
