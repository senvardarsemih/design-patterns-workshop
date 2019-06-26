using StrategyPattern.Base;
using StrategyPattern.Models;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class MidDevSalaryCalculator : ICalculatorStrategy
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperSummary> reports) => reports
        .Where(r => r.Level == DeveloperLevel.Senior)
        .Select(r => r.CalculateSalary() * 1.5)
        .Sum();
    }
}
