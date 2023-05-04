﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Interfaces
{
    internal interface ITriangle : IFigure
    {
        double A { get; }
        double B { get; }
        double C { get; }
    }
}
