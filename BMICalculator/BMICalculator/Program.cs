using System;
using BMICalculator.Models;

namespace BMICalculator
{
    internal class Program
    {
        static void Main()
        {
            var bmiInput = CollectBmiInput();
            //var result = new BmiCalculator(bmiInput).GetResult();
            //Console.WriteLine($"BMI => {result}");
            Console.ReadLine();
        }

        private static BmiInput CollectBmiInput()
        {
            Console.Write("Please input your gender. (M/F) => ");
            var gender = Console.ReadLine();

            Console.Write("Please input your height in meter. (180cm then 1.8) => ");
            var heightInMeter = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please input your weight in kilogram. (56KG then 56) => ");
            var weightInKilogram = Convert.ToDecimal(Console.ReadLine());

            return new BmiInput(gender, heightInMeter, weightInKilogram);
        }
    }
}
