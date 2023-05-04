using AreaCalculator.Implementations;
using AreaCalculator.Interfaces;

namespace AreaCalculator
{
    public static class Calculator
    {
        public static double? Calculate(params double[] sides)
        {
            IFigure? figure = null;

            if (sides.Length == 1)
                figure = new Circle(sides[0]);
            else if (sides.Length == 3)
                figure = new Triangle(sides[0], sides[1], sides[2]);
            else 
                throw new NotImplementedException("Нет реализации для заданной фигуры");
            
            return figure?.GetArea();
        }
        public static bool CheckRightTriangle(double a, double b, double c) =>
            new Triangle(a, b, c).IsRightTriangle();
    }
}