using StrategyPattern.Base;
using System;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy class
    /// </summary>
    public class Dhalsim : IFighterStrategy
    {
        public string ComboMove(char comboKey)
        {
            if (comboKey == 'D' || comboKey == 'd')
            {
                return "Yoga Flame !";
            }
            return "You hit the wrong key !";
        }
    }
}
