using StrategyPattern.Base;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace StrategyPattern.Context
{
    // The Context defines the interface of interest to clients.
    public class CalculatorContext
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private ICalculatorStrategy _calculatorStrategy;

        public CalculatorContext()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public CalculatorContext(ICalculatorStrategy strategy)
        {
            _calculatorStrategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(ICalculatorStrategy strategy)
        {
            _calculatorStrategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public double Calculate(IEnumerable<DeveloperSummary> reports) => _calculatorStrategy.CalculateTotalSalary(reports);
    }
}
