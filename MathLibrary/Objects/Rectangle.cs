using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary.Computations;

namespace MathLibrary.Objects
{
    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

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
