namespace Builder
{
    public class EquipmentBuilder
    {
        private Equipment _equipment;

        public EquipmentBuilder()
        {
            _equipment = new Equipment();
        }

        public EquipmentBuilder SetWeapon(string weapon)
        {
            _equipment.Weapon = weapon;
            return this;
        }

        public EquipmentBuilder SetArmor(string armor)
        {
            _equipment.Armor = armor;
            return this;
        }

        public EquipmentBuilder SetHelmet(string helmet)
        {
            _equipment.Helmet = helmet;
            return this;
        }

        public EquipmentBuilder SetBoots(string boots)
        {
            _equipment.Boots = boots;
            return this;
        }

        public EquipmentBuilder AddAccessory(string accessory)
        {
            if (!_equipment.Accessories.Contains(accessory))
                _equipment.Accessories.Add(accessory);
            return this;
        }

        public Equipment Build()
        {
            return _equipment;
        }
    }
}