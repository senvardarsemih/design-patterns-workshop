using StrategyPattern.Models;
using System.Collections.Generic;

namespace StrategyPattern.Base
{
    // The Strategy interface declares operations common to all supported versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete Strategies.
    public interface ICalculatorStrategy
    {
        double CalculateTotalSalary(IEnumerable<DeveloperSummary> reports);
    }
}
