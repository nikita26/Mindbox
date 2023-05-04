using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Interfaces
{
    internal interface ICircle : IFigure
    {
        double Radius { get; }
    }
}
