using System;
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

namespace Assignment_1_RPG_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Achieuw");
            Console.WriteLine($"Name: {mage.Name} Level: {mage.Level}");
        }
    }
}
