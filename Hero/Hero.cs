using System;
using System.Collections.Generic;
using RPGCharacters.Items;

namespace RPGCharacters
{
    /// <summary>
    /// Base class for heroes
    /// </summary>
    public abstract class Hero
    {
        /// <summary>
        /// Instantiates a new unarmed hero with default stats
        /// </summary>
        /// <param name="name"></param>
        public Hero(string name)
        {
            Name = name;
            InitializeHero();
        }
        public void InitializeHero()
        {
            Level = 1;
            BaseStats = new(1, 1, 1);
            StatIncreaseOnLevelUp = new(1, 1, 1);
            Equipment = new();
            Weapon = new(Weapon.Types.Unarmed);
            WeaponProficiencies = new();
            WeaponProficiencies.Add(Weapon.Types.Unarmed);
        }

        #region Fields
        public string Name { get; set; }
        public int Level { get; set; }
        public PrimaryAttributes BaseStats { get; set; }
        public PrimaryAttributes StatIncreaseOnLevelUp { get; set; }
        public Equipment Equipment { get; set; }
        public Weapon Weapon { get; set; }
        public abstract List<Weapon.Types> WeaponProficiencies { get; set; }

        // Armor
        // Armor proficiencies
        #endregion

        /// <summary>
        /// Deal damage based on equipped weapon and primary attribute (Weapon DPS * (1 + primarystat / 100))
        /// </summary>
        /// <param name="primaryStat">Stat to use for calculating total DPS</param>
        /// <returns>Total DPS</returns>
        public abstract int DealDamage();

        /// <summary>
        /// Increase hero level and primary attributes
        /// </summary>
        public virtual void LevelUp()
        {
            Level++;
            // Operator overloading
            BaseStats += StatIncreaseOnLevelUp;
        }
        /// <summary>
        /// Checks requirements to equip a weapon in the first slot 
        /// </summary>
        /// <param name="itemToEquip"></param>
        /// <returns>The weapon that is equipped</returns>
        public Weapon EquipWeapon(Weapon weaponToEquip)
        {
            // Check requirements to equip weapon
            if(Level >= weaponToEquip.RequiredLevel)
            {
                // Check if hero class can use this weapon
                foreach (Weapon.Types type in WeaponProficiencies)
                {
                    if(type == weaponToEquip.Type)
                    {
                        Equipment.EquipItem(1, weaponToEquip);
                        return weaponToEquip;
                    }
                }
            }

            throw new WeaponException("Invalid weapon. Could not be equipped.");
        }
        public void EquipArmor(int slot, Item itemToEquip)
        {
            if (slot > 0 && slot <= Equipment.slots)
                Equipment.EquipItem(slot, itemToEquip);
        }
    }
}
