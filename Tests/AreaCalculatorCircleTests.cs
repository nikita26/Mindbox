using Xunit;
using AreaCalculator;

namespace Tests
{
    public class AreaCalculatorCircleTests
    {
        [Fact]
        public void AreaCalculator_Calculate_Circle_Success()
        {
            double? result = Calculator.Calculate(4);
            Assert.Equal(50.26548245743669, result);
        }
        [Fact]
        public void AreaCalculator_Calculate_Circle_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => { double? result = Calculator.Calculate(-1); });
        }
    }
}