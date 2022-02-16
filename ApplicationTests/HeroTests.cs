using Xunit;
using RPGCharacters.Items;
using Newtonsoft.Json;

namespace RPGCharacters
{
    public class HeroTests
    {
        [Fact]
        public void Hero_HeroLevelCreation_ShouldInitializeAtLevelOne()
        {
            // Arrange
            Hero mage = new Mage("test");
            int level = 1;
            int expected = level;
            // Act
            int actual = mage.Level;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_HeroLevelUp_ShouldLevelUp()
        {
            // Arrange
            Hero mage = new Mage("test");
            int level = 2;
            int expected = level;
            mage.LevelUp();
            // Act
            int actual = mage.Level;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_InitializeHeroPrimaryStats_ShouldInitializeHeroWithCorrectPrimaryStats()
        {
            // Arrange
            Hero mage = new Mage("test");
            PrimaryAttributes primaryAttributes = new PrimaryAttributes(1, 1, 8);
            //PrimaryAttributes expected = primaryAttributes;
            var expected = JsonConvert.SerializeObject(primaryAttributes);
            // Act
            var actual = JsonConvert.SerializeObject(mage.BaseStats);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_HeroPrimaryStatsIncrease_ShouldIncreaseHeroPrimaryStatsOnLevelUp()
        {
            // Arrange
            Hero mage = new Mage("test");
            PrimaryAttributes primaryAttributes = new PrimaryAttributes(2, 2, 13);
            mage.LevelUp();
            //PrimaryAttributes expected = primaryAttributes;
            var expected = JsonConvert.SerializeObject(primaryAttributes);
            // Act
            var actual = JsonConvert.SerializeObject(mage.BaseStats);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_DealDamageUnarmed_ShouldDealDamage()
        {
            //Arrange
            Mage mage = new Mage("test");
            double expected = 1 * (1 + (8 / 100.0));
            // Act
            double actual = mage.DealDamage();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_DealDamageWithWeapon_ShouldDealDamage()
        {
            //Arrange
            Mage mage = new Mage("test");
            Weapon weapon = new Weapon("test", 1, Weapon.Types.Staff, 7, 1.1);
            mage.EquipWeapon(weapon, mage.WeaponProficiencies, 1);
            double expected = (7 * 1.1) * (1 + (8 / 100.0));
            // Act
            double actual = mage.DealDamage();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Hero_DealDamageWithWeaponAndArmorEquipped_ShouldDealExtraDamage()
        {
            //Arrange
            Mage mage = new Mage("test");
            Weapon weapon = new Weapon("test", 1, Weapon.Types.Staff, 7, 1.1);
            mage.EquipWeapon(weapon, mage.WeaponProficiencies, 1);
            Armor armor = new Armor("test", 1, Armor.Types.Cloth, new PrimaryAttributes(1, 1, 5), Item.Slot.SLOT_BODY);
            mage.EquipArmor(armor, mage.ArmorProficiencies, 1);
            double expected = (7 * 1.1) * (1 + ((8 + 5) / 100.0));
            // Act
            double actual = mage.DealDamage();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
