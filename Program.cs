using System;
using RPGCharacters.Items;

/// <summary>
/// a) Various character classes having attributes which increase at different rates as the character gains levels.
/// b) Equipment, such as armor and weapons, that characters can equip. The equipped items will alter the power of
/// the character, causing it to deal more damage and be able to survive longer. Certain characters can equip
/// certain item types.
/// c) Summary(///) tags for each method you write, explaining what the method does, any exceptions it can throw,
/// and what data it returns(if applicable).You do not need to write summary tags for overloaded methods.
/// d) Custom exceptions.There are two custom exceptions you are required to write, as detailed in Appendix B.
/// e) Full test coverage of the functionality. Some testing data is provided, it can be used to complete the assignment
/// in a test-driven development manner.
/// </summary>

namespace RPGCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fake loading
            //int count = 0;
            //while (count < 3)
            //{
            //    switch (count)
            //    {
            //        case 0:
            //            Console.WriteLine("Fetching all the promises...");
            //            break;
            //        case 1:
            //            Console.WriteLine("Declaring variables with actual types...");
            //            break;
            //        case 2:
            //            Console.WriteLine("Misspelling a varibael name 42 times...");
            //            break;
            //    }
            //    for (int i = 0; i < 800000000; i++)
            //    {
            //    }

            //    count++;
            //}
            #endregion
            #region Welcome message
            Console.Clear();
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Welcome to World of Equipping an Item which exist |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            #endregion
            #region Initialize class
            Console.WriteLine("Choose your class: ");
            Console.WriteLine("1: Mage ");
            Console.WriteLine("2: Warrior ");
            Console.WriteLine("3: Ranger ");
            Console.WriteLine("4: Rogue ");
            int type = int.Parse(Console.ReadLine());
            Console.Write("Choose a name: ");
            string name = Console.ReadLine().ToString().ToLower();
            #endregion

            // Somehow instantiate a base class that can be inherited by specific class in switch statement?
            Mage mage = new Mage(name);

            switch (type)
            {
                case 1:
                    Console.WriteLine("Choose a weapon: ");
                    Console.WriteLine("1: Wand");
                    Console.WriteLine("2: Staff");
                    int weaponType = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

            
        }
    }
}
