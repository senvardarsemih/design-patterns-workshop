using System;
using System.Threading;
using StrategyPattern.Base;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy class
    /// </summary>
    public class Ken : IFighterStrategy
    {
        public void ComboMove()
        {
            Console.WriteLine("Rotating the analog...please press K for combo");
            var pressedKey = Console.ReadKey().KeyChar;
            if (pressedKey == 'K' || pressedKey == 'k')
            {
                Console.WriteLine("\nHadoken !");
            }
            else
            {
                Console.WriteLine("\nYou miss the combo !");
            }
            Console.WriteLine("Press any key to continue !");
        }
    }
}
