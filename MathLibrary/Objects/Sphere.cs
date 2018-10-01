using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary.Computations;

namespace MathLibrary.Objects
{
    public class Sphere : IShape
    {
        public double Radius { get; set; }

        public double Volume()
        {
            return ComputationManager.Volume(this);
        }

        public double Area() //This is the surface area of the sphere
        {
            return ComputationManager.Area(this);
        }
    }
}
