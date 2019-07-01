using System;
using StrategyPattern.Base;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy class
    /// </summary>
    public class Ryu : IFighterStrategy
    {
        public void ComboMove()
        {
            Console.WriteLine("Rotating the analog...please press R for combo !");
            var pressedKey = Console.ReadKey().KeyChar;
            if (pressedKey == 'R' || pressedKey == 'r')
            {
                Console.WriteLine("\nShoryuken !");
            }
            else
            {
                Console.WriteLine("\nYou miss the combo !");
            }
            Console.WriteLine("Press any key to continue !");
        }
    }
}
