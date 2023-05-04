using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Implementations
{
    public class RightTriangle : Triangle, IRightTriangle
    {
        public RightTriangle(double side1, double side2, double side3) 
            : base(side1, side2, side3)
        {
        }

        public bool IsRightTriangle() =>
                Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)) ||
                Math.Pow(B, 2) == (Math.Pow(C, 2) + Math.Pow(A, 2)) ||
                Math.Pow(C, 2) == (Math.Pow(A, 2) + Math.Pow(B, 2));
    }
}