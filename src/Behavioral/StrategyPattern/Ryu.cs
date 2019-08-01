using StrategyPattern.Base;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy class
    /// </summary>
    public class Ryu : IFighterStrategy
    {
        public string ComboMove(char comboKey)
        {
            if (comboKey == 'R' || comboKey == 'r')
            {
                return "Shoryuken !";
            }
            return "You hit the wrong key !";
        }
    }
}
