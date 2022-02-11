using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Items
{
    class Armor
    {
        public PrimaryAttributes Stats { get; set; }

        public Armor()
        {
            Stats = new PrimaryAttributes(0, 0, 0);
        }
    }
}
