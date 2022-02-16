using RPGCharacters.Items;
using System;
using System.Collections.Generic;

namespace RPGCharacters
{
    public class Mage : Hero
    {
        public override List<Weapon.Types> WeaponProficiencies { get; set; }
        public override List<Armor.Types> ArmorProficiencies { get; set; }

        public Mage(string name) : base(name)
        {
            BaseStats.Intelligence = 8;
            StatIncreaseOnLevelUp.Intelligence = 5;
            WeaponProficiencies.Add(Weapon.Types.Wand);
            WeaponProficiencies.Add(Weapon.Types.Staff);
            ArmorProficiencies.Add(Armor.Types.Cloth);
        }
        public override double DealDamage()
        {
            double damage = (Weapon.DPS * (1 + ((BaseStats + GetStats()).Intelligence / 100.0)));
            return damage;
        }
    }
}
