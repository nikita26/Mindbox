using Xunit;
using AreaCalculator;

namespace Tests
{
    public class AreaCalculatorTriangleTests
    {
        [Fact]
        public void AreaCalculator_Calculate_Triangle_Success()
        {
            double? result = Calculator.Calculate(3, 4, 5);
            Assert.Equal(6, result);
        }
        [Fact]
        public void AreaCalculator_Calculate_Triangle_ArgumentException()
        {

            Assert.Throws<ArgumentException>(() => { double? result = Calculator.Calculate(-1, 2, 3); });
            Assert.Throws<ArgumentException>(() => { double? result = Calculator.Calculate(1, -2, 3); });
            Assert.Throws<ArgumentException>(() => { double? result = Calculator.Calculate(1, 2, 0); });
        }
        [Fact]
        public void AreaCalculator_Calculate_Triangle_NotExist()
        {
            Assert.Throws<ArgumentException>(() => { double? result = Calculator.Calculate(1,2,3); });
            Assert.Throws<ArgumentException>(() => { double? result = Calculator.Calculate(2,3,1); });
            Assert.Throws<ArgumentException>(() => { double? result = Calculator.Calculate(3,1,2); });
        }
    }
}