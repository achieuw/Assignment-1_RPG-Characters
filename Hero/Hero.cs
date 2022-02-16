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
            WeaponProficiencies = new();
            WeaponProficiencies.Add(Weapon.Types.Unarmed);
            Weapon = new("Unarmed", 1, Weapon.Types.Unarmed, 1, 1);
            ArmorProficiencies = new();
        }

        #region Fields
        public string Name { get; set; }
        public int Level { get; set; }
        public PrimaryAttributes BaseStats { get; set; }
        public PrimaryAttributes StatIncreaseOnLevelUp { get; set; }
        public Equipment Equipment { get; set; }
        public Weapon Weapon { get; set; }
        public abstract List<Weapon.Types> WeaponProficiencies { get; set; }
        public abstract List<Armor.Types> ArmorProficiencies { get; set; }
        #endregion

        /// <summary>
        /// Deal damage based on equipped weapon and primary attribute (Weapon DPS * (1 + primarystat / 100))
        /// </summary>
        /// <param name="primaryStat">Stat to use for calculating total DPS</param>
        /// <returns>Total DPS</returns>
        public abstract double DealDamage();

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
        /// Equips weapon
        /// </summary>
        /// <param name="armorToEquip"></param>
        /// <param name="armorProficiencies"></param>
        /// <param name="heroLevel"></param>
        /// <returns>Success string</returns>
        public string EquipWeapon(Weapon weaponToEquip, List<Weapon.Types> WeaponProficiencies, int heroLevel)
        {
            // Check requirements to equip weapon
            if (heroLevel >= weaponToEquip.RequiredLevel && weaponToEquip.ItemSlot == Item.Slot.SLOT_WEAPON && weaponToEquip.RequiredLevel > 0)
            {
                // Check if hero class can use this weapon
                foreach (Weapon.Types type in WeaponProficiencies)
                {
                    if (type == weaponToEquip.Type)
                    {
                        Weapon = weaponToEquip;
                        return "New weapon equipped!";
                    }
                }
            }
            throw new WeaponException("Invalid weapon. Could not be equipped.");
        }

        /// <summary>
        /// Equips armor the the appropriate equipment slot
        /// </summary>
        /// <param name="armorToEquip"></param>
        /// <param name="armorProficiencies"></param>
        /// <param name="heroLevel"></param>
        /// <returns>Success string</returns>
        public string EquipArmor(Armor armorToEquip, List<Armor.Types> armorProficiencies, int heroLevel)
        {
            // Check requirements to equip weapon
            if (heroLevel >= armorToEquip.RequiredLevel && armorToEquip.RequiredLevel > 0)
            {
                // Check if hero class can use this weapon
                foreach (Armor.Types type in armorProficiencies)
                {
                    if (type == armorToEquip.Type)
                    {
                        switch (armorToEquip.ItemSlot)
                        {
                            case Item.Slot.SLOT_HEAD:
                                Equipment.EquipItem(2, armorToEquip);
                                break;
                            case Item.Slot.SLOT_BODY:
                                Equipment.EquipItem(3, armorToEquip);
                                break;
                            case Item.Slot.SLOT_LEGS:
                                Equipment.EquipItem(4, armorToEquip);
                                break;
                        }
                        return "New armor equipped!";
                    }
                }
            }

            throw new ArmorException("Invalid weapon. Could not be equipped.");
        }

        /// <summary>
        /// Get the primary stats from the hero armor
        /// </summary>
        /// <returns>Total value of the armor stats</returns>
        public PrimaryAttributes GetStats()
        {
            PrimaryAttributes total = new PrimaryAttributes(0, 0, 0);
            foreach(KeyValuePair<int, Armor> armor in Equipment.Gear)
            {
                if(armor.Value != null)
                    total += armor.Value.Stats;
            }

            return total;
        }
    }
}
