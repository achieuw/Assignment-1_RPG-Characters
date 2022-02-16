using System;

namespace RPGCharacters.Items
{
    public class Armor : Item
    {
        public override string Name { get; set; }
        public override int RequiredLevel { get; set; }
        public override Slot ItemSlot { get; set; }
        public PrimaryAttributes Stats;
        public Types Type { get; set; }

        public enum Types
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }

        public Armor(string name, int requiredLevel, Types type, PrimaryAttributes stats, Slot slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Type = type;
            ItemSlot = slot;
            Stats = stats;
        }
    }
}
