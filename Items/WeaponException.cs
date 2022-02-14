using System;

namespace RPGCharacters.Items
{
    public class WeaponException : Exception
    {
        public WeaponException(string message) : base(message)
        {
        }

        public override string Message => "Weapon Exception";
    }
}
