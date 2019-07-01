using System;
using StrategyPattern.Base;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy class
    /// </summary>
    public class Dhalsim : IFighterStrategy
    {
        public void ComboMove()
        {
            Console.WriteLine("Rotating the analog...please press D for combo !");
            var pressedKey = Console.ReadKey().KeyChar;
            if (pressedKey == 'D' || pressedKey == 'd')
            {
                Console.WriteLine("\nYoga Flame !");
            }
            else
            {
                Console.WriteLine("\nYou miss the combo !");
            }
            Console.WriteLine("Press any key to continue !");
        }
    }
}
