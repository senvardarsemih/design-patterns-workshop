using StrategyPattern;
using StrategyPattern.Context;

namespace SharpPatterns.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //BEGIN_STRATEGY PATTERN
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.

            var fighterContext = new FighterContext();
            fighterContext.SetStrategy(new Ryu());
            fighterContext.DoCombo();

            fighterContext.SetStrategy(new Ken());
            fighterContext.DoCombo();

            fighterContext.SetStrategy(new Dhalsim());
            fighterContext.DoCombo();

            //END_STRATEGY PATTERN

        }
    }
}
