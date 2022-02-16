using System.Collections.Generic;

namespace RPGCharacters.Items
{
    public class Equipment
    {
        public Dictionary<int, Armor> Gear = new();
        private readonly int slots = 4;
        public int Slots { get => slots; }

        public Equipment()
        {
            InitializeGearSlots(Slots);
        }
        public void InitializeGearSlots(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Gear.Add(i, null);
            }
        }
        public int GetEquipmentSize()
        {
            return Gear.Count;
        }
        public Item GetEquipmentInSlot(int slot)
        {
            return Gear[slot];
        }
        public void EquipItem(int slot, Armor item)
        {
            Gear[slot] = item;
        }
    }
}