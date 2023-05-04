using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Implementations
{
    public class Circle : ICircle
    {
        public double Radius { get; }

        public Circle(double radius) 
        {
            if (radius < 0)
                throw new ArgumentException("Радиус круга не может быть отрицательным числом");
            Radius = radius;
        }

        public double GetArea() => Math.PI * Math.Pow(Radius,2);
    }
}
