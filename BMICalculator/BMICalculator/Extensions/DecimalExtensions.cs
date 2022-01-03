using System;

namespace BMICalculator.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal RoundUpTo2DecimalPlaces(this decimal input)
        {
            return Math.Ceiling(input * 100) / 100;
        }
    }
}