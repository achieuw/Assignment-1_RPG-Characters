using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Items
{
    abstract class Item
    {
        public string Name { get; set; }
        public abstract int RequiredLevel { get; set; }
        public abstract int Slot { get; set; }
    }
}
