using FactoryPattern;
using FactoryPattern.Base;
using Shouldly;
using Xunit;

namespace SharpPatterns.Tests
{
    public class FactoryPatternTests
    {
        [Theory]
        [InlineData("5 Pro")]
        public void FactoryPatternShouldWorkWithoutException(string version)
        {
            //Act
            var exception = Record.Exception(() => GameConsole.InitializeFactories()
                 .ExecuteCreation(ConsoleTypes.PlayStation, version)
                 .RunTheGame());

            //Assert
            exception.ShouldBeNull();
        }

        [Theory]
        [InlineData("DS")]
        public void RunTheGameShouldReturnValidConsoleInfo(string version)
        {
            //Arrange
            var correctSut = $"Running the game on {nameof(Nintendo)} {version} !";

            //Act
            var sut = GameConsole.InitializeFactories()
                .ExecuteCreation(ConsoleTypes.Nintendo, version)
                .RunTheGame();

            //Assert
            sut.ShouldBe(correctSut);
        }
    }
}
