using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
