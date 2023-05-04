using Xunit;
using AreaCalculator;

namespace Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void AreaCalculator_Calculate_Figure_NotImplementedException()
        {
            var implementedSides = new int[] {1,3};
            for (int i = 1; i <= 100; i++)
                if (!implementedSides.Contains(i))
                    Assert.Throws<NotImplementedException>(() => {
                        double? result = Calculator.Calculate(Enumerable.Range(1, i).Select(s => (double)s).ToArray());
                    });
        }
    }
}