using Xunit;
using AreaCalculator;

namespace Tests
{
    public class AreaCalculatorCheckRightTriangleTests
    {
        [Fact]
        public void AreaCalculator_CheckRightTriangle_Success()
        {
            bool rightTriangle = Calculator.CheckRightTriangle(3.5, 2.8, 2.1);
            bool notRightTriangle = Calculator.CheckRightTriangle(3, 2, 2);

            Assert.True(rightTriangle);
            Assert.False(notRightTriangle);
        }
    }
}