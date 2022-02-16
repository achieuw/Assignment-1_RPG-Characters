using RPGCharacters.Items;
using System.Collections.Generic;

namespace RPGCharacters
{
    public class Rogue : Hero
    {
        public override List<Weapon.Types> WeaponProficiencies { get; set; }
        public override List<Armor.Types> ArmorProficiencies { get; set; }

        public Rogue(string name) : base(name)
        {
            BaseStats.Strength = 2;
            BaseStats.Dexterity = 6;
            StatIncreaseOnLevelUp.Dexterity = 4;
            WeaponProficiencies.Add(Weapon.Types.Dagger);
            WeaponProficiencies.Add(Weapon.Types.Sword);
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