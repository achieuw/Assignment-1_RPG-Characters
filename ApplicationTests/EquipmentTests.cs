using Xunit;

namespace RPGCharacters.Items
{
    public class EquipmentTests
    {
        #region Creation
        [Fact]
        public void InitializeEquipment_CreateNewEquipment_ShouldInitializeEquipmentWithSlots()
        {
            // Arrange
            Equipment equipment = new Equipment();
            int size = 4;
            int expected = size;
            // Act
            int actual = equipment.GetEquipmentSize();
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion
        #region Equip Weapon
        [Fact]
        public void EquipWeapon_EquipValidWeapon_ShouldEquipWeapon()
        {
            // Arrange
            Mage mage = new Mage("test");
            Weapon weapon = new Weapon("testWeapon", 1, Weapon.Types.Unarmed, 1, 1);
            string expected = "New weapon equipped!";
            // Act
            string actual = mage.EquipWeapon(weapon, mage.WeaponProficiencies, mage.Level);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        
        public void EquipWeapon_EquipInvalidWeaponLevel_ShouldThrowException()
        {
            // Arrange
            Mage mage = new Mage("test");
            Weapon weapon = new Weapon("testWeapon", 2, Weapon.Types.Unarmed, 1, 1);
            // Act and assert
            Assert.Throws<WeaponException>(() => mage.EquipWeapon(weapon, mage.WeaponProficiencies, mage.Level));
        }
        [Fact]
        public void EquipWeapon_EquipInvalidWeaponType_ShouldThrowException()
        {
            // Arrange
            Mage mage = new Mage("test");
            Weapon weapon = new Weapon("testWeapon", 1, Weapon.Types.Axe, 1, 1);
            // Act and assert
            Assert.Throws<WeaponException>(() => mage.EquipWeapon(weapon, mage.WeaponProficiencies, mage.Level));
        }
        [Fact]
        public void EquipWeapon_EquipInvalidWeaponSlot_ShouldThrowException()
        {
            // Arrange
            Mage mage = new Mage("test");
            Weapon weapon = new Weapon("testWeapon", 1, Weapon.Types.Unarmed, 1, 1);
            weapon.ItemSlot = Item.Slot.SLOT_LEGS;
            // Act and assert
            Assert.Throws<WeaponException>(() => mage.EquipWeapon(weapon, mage.WeaponProficiencies, mage.Level));
        }
        #endregion
        #region Equip Armor
        [Fact]
        public void EquipArmor_EquipInvalidArmorType_ShouldThrowException()
        {
            // Arrange
            Mage mage = new Mage("test");
            PrimaryAttributes stats = new PrimaryAttributes();
            Armor armor = new Armor("testWeapon", 1, Armor.Types.Plate, stats, Item.Slot.SLOT_BODY);
            // Act and assert
            Assert.Throws<ArmorException>(() => mage.EquipArmor(armor, mage.ArmorProficiencies, mage.Level));
        }
        [Fact]
        public void EquipArmor_EquipInvalidArmorLevel_ShouldThrowException()
        {
            // Arrange
            Mage mage = new Mage("test");
            PrimaryAttributes stats = new PrimaryAttributes();
            int level = 2;
            Armor armor = new Armor("testWeapon", level, Armor.Types.Cloth, stats, Item.Slot.SLOT_BODY);
            // Act and assert
            Assert.Throws<ArmorException>(() => mage.EquipArmor(armor, mage.ArmorProficiencies, mage.Level));
        }
        #endregion
    }
}
