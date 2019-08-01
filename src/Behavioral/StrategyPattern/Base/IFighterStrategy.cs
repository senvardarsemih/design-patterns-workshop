namespace StrategyPattern.Base
{
    // The Strategy interface declares operations common to all supported versions of some algorithm.
    // The Context uses this interface to call the algorithm defined by Concrete Strategies.
    public interface IFighterStrategy
    {
        string ComboMove(char comboKey);
    }
}
