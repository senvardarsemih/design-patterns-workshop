﻿using StrategyPattern.Base;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy class
    /// </summary>
    public class SeniorDevSalaryCalculator : ICalculatorStrategy
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperSummary> reports) => reports
        .Where(r => r.Level == DeveloperLevel.Senior)
        .Select(r => r.CalculateSalary() * 2)
        .Sum();
    }
}
