using System;
using StrategyPattern.Base;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy class
    /// </summary>
    public class Ken : IFighterStrategy
    {
        public string ComboMove(char comboKey)
        {
            if (comboKey == 'K' || comboKey == 'k')
            {
                return "Hadoken !";
            }
            return "You hit the wrong key !";
        }
    }
}
