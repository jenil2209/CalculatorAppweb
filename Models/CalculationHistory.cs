// CalculationHistory.cs
using System;

namespace CalculatorLibrary
{
    public class CalculationHistory
    {
        public int Id { get; set; }
        public string Calculation { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
