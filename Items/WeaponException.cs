using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters.Items
{
    class WeaponException : Exception
    {
        public WeaponException(string message) : base(message)
        {
        }

        public override string Message => "Weapon Exception";
    }
}
