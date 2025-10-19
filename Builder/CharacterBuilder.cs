﻿using System;
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
            _character = new GameCharacter { Class = CharacterClass.None };
        }
        public GameCharacter GetResult()
        {
            var resultCharacter = _character;
            _character = new GameCharacter();
            return resultCharacter;
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

        public ICharacterBuilder SetStrenght(int strenght)
        {
            _character.Strength = Math.Clamp(strenght, 0, 10);
            return this;
        }
      
        public ICharacterBuilder SetWeapon(string weaponName)
        {
            _character.Equipment.Weapon = weaponName;
            return this;
        }

        public ICharacterBuilder SetArmor(string armorName)
        {
            _character.Equipment.Armor = armorName;
            return this;
        }

        public ICharacterBuilder SetHelmet(string helmetName)
        {
            _character.Equipment.Helmet = helmetName;
            return this;
        }

        public ICharacterBuilder SetBoots(string bootsName)
        {
            _character.Equipment.Boots = bootsName;
            return this;
        }

        public ICharacterBuilder AddAccessory(string accessoryName)
        {
            _character.Equipment.Accessories.Add(accessoryName);
            return this;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(_character.Name))
                throw new InvalidOperationException("нет имени персонажа");
            if (_character.Class == CharacterClass.None)
                throw new InvalidOperationException("не установлен класс персонажа");
        }

        public ICharacterBuilder SetMana(int mana)
        {
            _character.Mana = mana;
            return this;
        }
    }
}
