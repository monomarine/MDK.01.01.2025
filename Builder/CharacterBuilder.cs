using System;

namespace Builder
{
    internal class CharacterBuilder : ICharacterBuilder
    {
        private GameCharacter _character;

        public CharacterBuilder()
        {
            _character = new GameCharacter();
        }

        public GameCharacter Reset()
        {
            var result = _character;
            _character = new GameCharacter();
            return result;
        }

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetClass(CharacterClass characterClass)
        {
            _character.Class = characterClass;
            return this;
        }

        public ICharacterBuilder SetLevel(int level)
        {
            _character.Level = Math.Clamp(level, 1, 100);
            return this;
        }

        public ICharacterBuilder SetHealth(int health)
        {
            _character.Health = Math.Clamp(health, 0, 200);
            return this;
        }

        public ICharacterBuilder SetMana(int mana)
        {
            _character.Mana = mana;
            return this;
        }

        public ICharacterBuilder SetStrenght(int strenght)
        {
            _character.Strength = strenght;
            return this;
        }

        public ICharacterBuilder SetIntelligence(int intelligance)
        {
            _character.Intelligence = intelligance;
            return this;
        }

        public ICharacterBuilder SetDexterity(int dexterity)
        {
            _character.Dexterity = dexterity;
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

        public ICharacterBuilder SetStats()
        {
            switch (_character.Class)
            {
                case CharacterClass.Warrior:
                    _character.Strength = 10;
                    _character.Health = 120;
                    break;
                case CharacterClass.Mage:
                    _character.Intelligence = 10;
                    _character.Mana = 150;
                    break;
                case CharacterClass.Archer:
                    _character.Dexterity = 12;
                    break;
                case CharacterClass.Rogue:
                    _character.Dexterity = 15;
                    _character.Strength = 8;
                    break;
                case CharacterClass.Priest:
                    _character.Mana = 100;
                    _character.Intelligence = 8;
                    break;
            }
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
            _character.Equipment.Accessories.Add(accessory);
            return this;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(_character.Name))
                throw new InvalidOperationException("Не задано имя персонажа");
            if (_character.Class == default)
                throw new InvalidOperationException("Не задан класс персонажа");
        }
    }
}
