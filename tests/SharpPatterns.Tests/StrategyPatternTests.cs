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

        [Theory]
        [InlineData('D')]
        [InlineData('d')]
        public void DhalsimShouldDoCombo_WhenDLetterIsPressed(char comboKey)
        {
            //Arrange
            var fighterContext = new FighterContext();
            fighterContext.SetStrategy(new Dhalsim());

            //Act
            var sut = fighterContext.DoCombo(comboKey);

            //Assert
            sut.ShouldContain("Yoga Flame");
        }

        [Theory]
        [InlineData('R')]
        [InlineData('r')]
        public void RyuShouldDoCombo_WhenRLetterIsPressed(char comboKey)
        {
            //Arrange
            var fighterContext = new FighterContext();
            fighterContext.SetStrategy(new Ryu());

            //Act
            var sut = fighterContext.DoCombo(comboKey);

            //Assert
            sut.ShouldContain("Shoryuken");
        }

        [Theory]
        [InlineData('K')]
        [InlineData('k')]
        public void KenShouldDoCombo_WhenKLetterIsPressed(char comboKey)
        {
            //Arrange
            var fighterContext = new FighterContext();
            fighterContext.SetStrategy(new Ken());

            //Act
            var sut = fighterContext.DoCombo(comboKey);

            //Assert
            sut.ShouldContain("Hadoken");
        }
    }
}
