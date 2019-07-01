using Shouldly;
using StrategyPattern;
using StrategyPattern.Context;
using Xunit;

namespace SharpPatterns.Tests
{
    public class StrategyPatternTests
    {
        [Fact]
        public void SetContextShouldWorkWithoutException()
        {
            var context = new FighterContext();
            var exception = Record.Exception(() => context.SetStrategy(new Ryu()));

            exception.ShouldBeNull();
        }
    }
}
