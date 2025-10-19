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
            _character = new GameCharacter();
        }

        public ICharacterBuilder AddAccessory(string value)
        {
            _character.Equipment.Accessories.Add(value);
            return this;
        }

        {
            _character.Skills.Add(skill);
            return this;
        }

        public GameCharacter Build()
        {
            if (Validate())
                return _character;
            else 
                throw new InvalidOperationException("Персонаж был сформирован неправильно");
        }

        public ICharacterBuilder SetAppearance(string appearance)
        {
            _character.Appearance = appearance;
            return this;
        }

        public ICharacterBuilder SetArmor(string value)
        {
            _character.Equipment.Armor = value;
            return this;
        }

        public ICharacterBuilder SetBoots(string value)
        {
            _character.Equipment.Boots = value;
            return this;
        }

        public ICharacterBuilder SetDexterity(int value)
        {
            _character.Dexterity = Math.Clamp(value, 0, 10);
            return this;
        }

        public ICharacterBuilder SetHealth(int value)
        {
            _character.Health = Math.Clamp(value, 0, 100);
            return this;
        }

        public ICharacterBuilder SetHelmet(string value)
        {
            _character.Equipment.Helmet = value;
            return this;
        }

        public ICharacterBuilder SetIntelligence(int value)
        {
            _character.Intelligence = Math.Clamp(value, 0, 10);
            return this;
        }

        public ICharacterBuilder SetLevel(int value)
        {
            _character.Level = Math.Clamp(value, 0, 100);
            return this;
        }

        public ICharacterBuilder SetMana(int value)
            {
                case CharacterClass.Warrior:
                    SetStrength(10);
                    SetDexterity(5);
                    SetMana(10);
                    SetHealth(100);
                    SetIntelligence(3);
                    SetAppearance("Воин");
                    break;
                case CharacterClass.Archer:
                    SetStrength(5);
                    SetDexterity(8);
                    SetMana(50);
                    SetHealth(80);
                    SetIntelligence(4);
                    SetAppearance("Лучник");
                    break;
                case CharacterClass.Rogue:
                    SetStrength(8);
                    SetDexterity(10);
                    SetMana(20);
                    SetHealth(50);
                    SetIntelligence(5);
                    SetAppearance("Разбойник");
                    break;
                case CharacterClass.Priest:
                    SetStrength(3);
                    SetDexterity(3);
                    SetMana(100);
                    SetHealth(50);
                    SetIntelligence(8);
                    SetAppearance("Жрец");
                    break;
                case CharacterClass.Mage:
                    SetStrength(2);
                    SetDexterity(2);
                    SetMana(100);
                    SetHealth(70);
                    SetIntelligence(10);
                    SetAppearance("Маг");
                    break;
                default:
                    SetAppearance("Отсутствует");
                    break;
            }
            _character.Dexterity = _character.Level * 5;
            _character.Strength = _character.Level * 3;
            _character.Mana = _character.Level / 2;
            _character.Intelligence = _character.Level / 2;
            _character.Health += _character.Level / 2;

            return this;
        }

        public ICharacterBuilder SetWeapon(string value)
        {
            _character.Equipment.Weapon = value; 
            return this;
        }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(_character.Name) || _character.Class != default(CharacterClass); 
        }
    }
}
