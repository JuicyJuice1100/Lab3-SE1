using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary.Computations;

namespace MathLibrary.Objects
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Volume()
        {
            return Double.NaN;
        }

        public double Area()
        {
            return ComputationManager.Area(this);
        }
    }
}
