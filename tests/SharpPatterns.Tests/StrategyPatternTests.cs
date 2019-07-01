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
            //Arrange
            var context = new FighterContext();

            //Act
            var exception = Record.Exception(() => context.SetStrategy(new Ryu()));

            //Assert
            exception.ShouldBeNull();
        }
    }
}
