using System;

namespace RPGCharacters.Items
{
    public class Weapon : Item
    {
        public override string Name { get; set; }
        public override int RequiredLevel { get; set; }
        public override Slot ItemSlot { get; set; }
        public Types Type { get; set; }
        private double AttackSpeed { get; set; }
        private double Damage { get; set; }
        // Calculate DPS with attackspeed defined as seconds between attacks
        public double DPS { get => AttackSpeed * Damage; }
        
        public enum Types {
            Unarmed,
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand
        }
        public Weapon()
        {

        }
        public Weapon(string name, int requiredLevel, Types weaponType, double damage, double attackSpeed)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Type = weaponType;
            ItemSlot = Slot.SLOT_WEAPON;
            Damage = damage;
            AttackSpeed = attackSpeed;
        }
    }
}
