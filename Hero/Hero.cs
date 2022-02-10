using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters
{
    class Hero : BaseHero
    {
        public override string Name { get; set; }
        public override int Level { get; set ; }
        public struct PrimaryStats
        {
            public static int strength = 1;
            public static int intelligence = 1;
            public static int dexterity = 1;
        }
        public Hero()
        {
            Level = 1;
        }
        public override void DealDamage()
        {

        }
        public override void LevelUp()
        {

        }

    }
}
