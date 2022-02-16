using System;

namespace RPGCharacters.Items
{
    public class ArmorException : Exception
    {
        public ArmorException(string message) : base(message)
        {
        }

        public override string Message => "Armor Exception";
    }
}