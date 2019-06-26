using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    public class DeveloperSummary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeveloperLevel Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }

        public double CalculateSalary() => WorkingHours * HourlyRate;
    }
}
