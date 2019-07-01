using FactoryPattern;
using FactoryPattern.Base;
using Shouldly;
using Xunit;

namespace SharpPatterns.Tests
{
    public class FactoryPatternTests
    {
        [Theory]
        [InlineData("test version 1.0")]
        public void FactoryPatternShouldWorkWithoutException(string version)
        {
            //Act
            var exception = Record.Exception(() => GameConsole.InitializeFactories().ExecuteCreation(ConsoleTypes.PlayStation, version)
                .RunTheGame());

            //Assert
            exception.ShouldBeNull();
        }
    }
}
