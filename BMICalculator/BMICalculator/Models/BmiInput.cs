namespace BMICalculator.Models
{
    public class BmiInput
    {
        public string Gender { get; }
        public decimal HeightInMeter { get; }
        public decimal WeightInKilogram { get; }

        public BmiInput(string gender, decimal heightInMeter, decimal weightInKilogram)
        {
            Gender = gender;
            HeightInMeter = heightInMeter;
            WeightInKilogram = weightInKilogram;
        }
    }
}