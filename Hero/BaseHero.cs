using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters
{
    abstract class BaseHero
    {
        public abstract string Name { get; set; }
        public abstract int Level { get; set; }
        public abstract void DealDamage();
        public abstract void LevelUp();
       
    }
}
