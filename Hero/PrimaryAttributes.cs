using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    /// <summary>
    /// Primary base attributes with properties: Strength, Dexterity, Intelligence. Defaults value to 1.
    /// </summary>
    public class PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public PrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        /// <summary>
        /// Operator overloading for adding primary attributes
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Sum of primary attributes</returns>
        public static PrimaryAttributes operator +(PrimaryAttributes p1, PrimaryAttributes p2)
        {
            return new PrimaryAttributes(p1.Strength + p2.Strength, p1.Dexterity + p2.Dexterity, p1.Intelligence + p2.Intelligence);
        }
    }
}
