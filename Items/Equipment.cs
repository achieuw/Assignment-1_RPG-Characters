using System;
using System.Collections.Generic;


namespace RPGCharacters.Items
{
    public class Equipment
    {
        private Dictionary<int, Item> Gear = new();

        public readonly int slots = 4;

        public Equipment()
        {
            //InitializeGearSlots(slots);
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
        public void AddToGearSlot(int slot, Item item)
        {
            Gear.Add(slot, item);
        }
    }
}
