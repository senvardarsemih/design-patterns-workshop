using StrategyPattern;
using StrategyPattern.Context;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace SharpPatterns.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //BEGIN_STRATEGY PATTERN
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var reports = new List<DeveloperSummary>
            {
            new DeveloperSummary {Id = 1, Name = "Dev-1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
            new DeveloperSummary { Id = 3, Name = "Dev-2", Level = DeveloperLevel.Mid, HourlyRate =   32.5, WorkingHours = 130 },
            new DeveloperSummary { Id = 2, Name = "Dev-3", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },

            };

            var calculatorContext = new CalculatorContext();
            calculatorContext.SetStrategy(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior developer salaries is: {juniorTotal}");

            calculatorContext.SetStrategy(new MidDevSalaryCalculator());
            var midTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for mid developer salaries is: {midTotal}");

            calculatorContext.SetStrategy(new SeniorDevSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior developer salaries is: {seniorTotal}");
            //END_STRATEGY PATTERN

        }
    }
}
