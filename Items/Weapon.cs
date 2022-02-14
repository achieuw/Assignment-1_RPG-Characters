using System;

namespace RPGCharacters.Items
{
    public class Weapon : Item
    {
        public override int RequiredLevel { get; set; }
        public override int Slot { get; set; }
        private double AttackSpeed { get; set; }
        private double Damage { get; set; }
        // Calculate DPS with attackspeed defined as seconds between attacks
        public double DPS { get => 1 / AttackSpeed * Damage; }
        public Types Type { get; set; }
        

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

        public Weapon(Types type)
        {
            RequiredLevel = 1;
            Slot = 1;
            Type = type;
            switch (type)
            {                
                case Types.Axe:
                    AttackSpeed = 2.2;
                    Damage = 45;
                    RequiredLevel = 3;
                    break;
                case Types.Bow:
                    AttackSpeed = 1.8;
                    Damage = 15;
                    break;
                case Types.Dagger:
                    AttackSpeed = 1.8;
                    Damage = 15;
                    RequiredLevel = 4;
                    break;
                case Types.Hammer:
                    AttackSpeed = 1.8;
                    Damage = 15;
                    RequiredLevel = 6;
                    break;
                case Types.Staff:
                    AttackSpeed = 3;
                    Damage = 75;
                    RequiredLevel = 5;
                    break;
                case Types.Sword:
                    AttackSpeed = 3;
                    Damage = 75;
                    break;
                case Types.Wand:
                    AttackSpeed = 1;
                    Damage = 25;
                    break;
                default: // Defaults to unarmed
                    AttackSpeed = 1.8;
                    Damage = 15;
                    break;
            }
        }
    }
}
