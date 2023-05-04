using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Implementations
{
    public class Triangle : ITriangle
    {
        public double A { get; }

        public double B { get; }

        public double C { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительними числами");

            if(side1 >= (side2+side3) || side2 >= (side3 + side1) || side3 >= (side1 + side2))
                throw new ArgumentException("Такого треугольника не существует");
            
            A = side1;
            B = side2;
            C = side3;
        }
        
        public double GetArea() 
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}