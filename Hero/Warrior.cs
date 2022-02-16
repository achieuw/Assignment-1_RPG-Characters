using RPGCharacters.Items;
using System.Collections.Generic;

namespace RPGCharacters
{
    public class Warrior : Hero
    {
        public override List<Weapon.Types> WeaponProficiencies { get; set; }
        public override List<Armor.Types> ArmorProficiencies { get; set; }

        public Warrior(string name) : base(name)
        {
            BaseStats.Strength = 5;
            BaseStats.Dexterity = 2;
            StatIncreaseOnLevelUp.Strength = 3;
            StatIncreaseOnLevelUp.Dexterity = 2;
            WeaponProficiencies.Add(Weapon.Types.Axe);
            WeaponProficiencies.Add(Weapon.Types.Hammer);
            WeaponProficiencies.Add(Weapon.Types.Sword);
            ArmorProficiencies.Add(Armor.Types.Mail);
            ArmorProficiencies.Add(Armor.Types.Plate);
        }
        public override double DealDamage()
        {
            double damage = (Weapon.DPS * (1 + ((BaseStats + GetStats()).Strength / 100.0)));
            return damage;
        }
    }
}