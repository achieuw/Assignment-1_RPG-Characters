using Assignment_1_RPG_Characters.Items;
using System;
using System.Collections.Generic;

namespace Assignment_1_RPG_Characters
{
    class Mage : Hero
    {
        public override List<Weapon.Types> WeaponProficiencies { get; set; }
        // Armor proficiencies
        public Mage(string name) : base(name)
        {
            BaseStats.Intelligence = 8;
            StatIncreaseOnLevelUp.Intelligence = 5;
            WeaponProficiencies.Add(Weapon.Types.Wand);
            WeaponProficiencies.Add(Weapon.Types.Staff);
        }
        public override int DealDamage() => (int)(Weapon.DPS * (1 + (BaseStats.Intelligence / 100.0)));
    }
}
