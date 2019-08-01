using System.Collections.Generic;
using Shouldly;
using StrategyPattern;
using StrategyPattern.Context;
using VisitorPattern;
using VisitorPattern.Base;
using Xunit;

namespace SharpPatterns.Tests
{
    public class VisitorPatternTests
    {
        private readonly List<IComponent> _components;

        public VisitorPatternTests()
        {
            //Setup
            _components = new List<IComponent>
            {
                new MarvelUniverse(),
                new DcUniverse()
            };
        }

        [Fact]
        public void CharacterVisitorShouldVisitUniverseskWithoutException()
        {
            //Arrange
            var cbVisitor = new ComicBookVisitor();

            //Act
            var exception = Record.Exception(() => Client.DoVisit(_components,cbVisitor));

            //Assert
            exception.ShouldBeNull();
        }

        [Fact]
        public void ComicBookVisitorShouldVisitUniverseskWithoutException()
        {
            //Arrange
            var chVisitor = new CharacterVisitor();

            //Act
            var exception = Record.Exception(() => Client.DoVisit(_components,chVisitor));

            //Assert
            exception.ShouldBeNull();
        }
    }
}
