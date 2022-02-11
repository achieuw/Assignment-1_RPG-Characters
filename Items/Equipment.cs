using System;
using System.Collections.Generic;


namespace Assignment_1_RPG_Characters.Items
{
    class Equipment
    {
        public Dictionary<int, Item> GearSlots;

        public readonly int MaxSlots = 4;

        public Equipment()
        {
            GearSlots = new();

            // Add slots for the gear and default items to null
            for (int i = 1; i <= MaxSlots; i++)
            {
                GearSlots.Add(i, null);
            }
        }

        public void AddToGearSlot(int slot, Item item)
        {
            GearSlots.Add(slot, item);
        }
    }
}
