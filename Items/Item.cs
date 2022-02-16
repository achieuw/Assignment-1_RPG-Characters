using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters.Items
{
    public abstract class Item
    {
        public abstract string Name { get; set; }
        public abstract int RequiredLevel { get; set; }
        public abstract Slot ItemSlot { get; set; }
        public enum Slot { 
            SLOT_WEAPON,
            SLOT_BODY,
            SLOT_HEAD,
            SLOT_LEGS
        }
    }
}
