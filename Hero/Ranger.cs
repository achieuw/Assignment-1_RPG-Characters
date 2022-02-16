using RPGCharacters.Items;
using System.Collections.Generic;

namespace RPGCharacters
{
    public class Ranger : Hero
    {
        public override List<Weapon.Types> WeaponProficiencies { get; set; }
        public override List<Armor.Types> ArmorProficiencies { get; set; }

        public Ranger(string name) : base(name)
        {
            BaseStats.Dexterity = 7;
            StatIncreaseOnLevelUp.Dexterity = 5;
            WeaponProficiencies.Add(Weapon.Types.Bow);
            ArmorProficiencies.Add(Armor.Types.Leather);
            ArmorProficiencies.Add(Armor.Types.Mail);
        }
        public override double DealDamage()
        {
            double damage = (Weapon.DPS * (1 + ((BaseStats + GetStats()).Dexterity / 100.0)));
            return damage;
        }
    }
}