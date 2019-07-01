using System;
using StrategyPattern.Base;

namespace StrategyPattern.Context
{
    // The Context defines the interface of interest to clients.
    public class FighterContext
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IFighterStrategy _fighterStrategy;

        public FighterContext()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public FighterContext(IFighterStrategy strategy)
        {
            _fighterStrategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IFighterStrategy strategy)
        {
            _fighterStrategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void DoCombo()
        {
            Console.WriteLine($"Beginning the combo move for {_fighterStrategy.GetType().Name} ...");
            _fighterStrategy.ComboMove();
            Console.ReadKey();
        }
    }
}
