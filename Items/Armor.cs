using System;


namespace RPGCharacters.Items
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
