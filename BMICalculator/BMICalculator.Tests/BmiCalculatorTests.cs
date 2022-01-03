using BMICalculator.Models;
using NUnit.Framework;

namespace BMICalculator.Tests
{
    [TestFixture]
    public class BmiCalculatorTests
    {
        [Test]
        public void GetResult()
        {
            var bmiInput = new BmiInput("m",1.68m,73);
            //Assert.AreEqual(25.87, new BmiCalculator(bmiInput).GetResult());
        }
    }
}
