using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CharacterBuilder : ICharacterBuilder
    {
        private GameCharacter _character;
        public CharacterBuilder()
        {
            Reset();
        }
        
        public ICharacterBuilder Reset()
        {
            _character = new GameCharacter();
            return this;
        }


        public ICharacterBuilder AddSkill(string skillName)
        {
            if (!_character.Skills.Contains(skillName))
                _character.Skills.Add(skillName);
            return this;
        }

        public ICharacterBuilder SetAppirance(string appirance)
        {
            _character.Appearance = appirance;
            return this;
        }

        public ICharacterBuilder SetClass(CharacterClass characterClass)
        {
            _character.Class = characterClass;
            return this;
        }

        public ICharacterBuilder SetDexterity(int dexterity)
        {
            _character.Dexterity = dexterity;
            return this;
        }

        public ICharacterBuilder SetHealth(int health)
        {
            _character.Health = Math.Clamp(health, 0, 100);
            return this;
        }

        public ICharacterBuilder SetIntelligence(int intelligance)
        {
            _character.Intelligence = Math.Clamp(intelligance, 3, 10);
            return this;
        }

        public ICharacterBuilder SetLevel(int level)
        {
            _character.Level = Math.Clamp(level, 0, 100);
            return this;
        }

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetStats()
        {
            switch (_character.Class)
            {
                case CharacterClass.Warrior:
                    _character.Dexterity = 3;
                    _character.Health = 100;
                    _character.Intelligence = 3;
                    _character.Strength = 10;
                    _character.Mana = 10;
                    break;
                case CharacterClass.Archer:
                    _character.Dexterity = 5;
                    _character.Health = 80;
                    _character.Intelligence = 5;
                    _character.Strength = 4;
                    _character.Mana = 4;
                    break;
                case CharacterClass.Priest:
                    _character.Dexterity = 0;
                    _character.Health = 15;
                    _character.Intelligence = 7;
                    _character.Strength = 2;
                    _character.Mana = 100;
                    break;
                case CharacterClass.Rogue:
                    _character.Dexterity = 15;
                    _character.Health = 50;
                    _character.Intelligence = 10;
                    _character.Strength = 5;
                    _character.Mana = 40;
                    break;
                case CharacterClass.Mage:
                    _character.Dexterity = 10;
                    _character.Health = 70;
                    _character.Intelligence = 10;
                    _character.Strength = 8;
                    _character.Mana = 150;
                    break;
            }
            _character.Dexterity = _character.Level * 5;
            _character.Strength = _character.Level * 3;
            _character.Mana = _character.Level / 2;
            _character.Intelligence = _character.Level / 2;
            _character.Health += _character.Level / 2;

            return this;
        }
        public ICharacterBuilder SetWeapon(string weapon)
        {
            _character.Equipment.Weapon = weapon;
            return this;
        }

        public ICharacterBuilder SetArmor(string armor)
        {
            _character.Equipment.Armor = armor;
            return this;
        }

        public ICharacterBuilder SetHelmet(string helmet)
        {
            _character.Equipment.Helmet = helmet;
            return this;
        }

        public ICharacterBuilder SetBoots(string boots) 
        {
            _character.Equipment.Boots = boots;
            return this;
        }

        public ICharacterBuilder AddAccessory(string accessory)
        {
            if (!_character.Equipment.Accessories.Contains(accessory))
                _character.Equipment.Accessories.Add(accessory);
            return this;
        }

        public ICharacterBuilder ClearAccessories()
        {
            _character.Equipment.Accessories.Clear();
            return this;
        }
    

    public ICharacterBuilder SetStrenght(int strenght)
        {
            _character.Strength = Math.Clamp(strenght, 0, 10);
            return this;
        }

        public GameCharacter Build()
        {
            if (string.IsNullOrEmpty(_character.Name))
                throw new InvalidOperationException("нет имени персонажа");
            if (string.IsNullOrEmpty(_character.Name))
                throw new InvalidOperationException("нет имени персонажа");

            var result = _character;
            _character = new GameCharacter();
            return result;
        }

        public ICharacterBuilder SetMana(int mana)
        {
            _character.Mana = mana;
            return this;
        }
    }
}
