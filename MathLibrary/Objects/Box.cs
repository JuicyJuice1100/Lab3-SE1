﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary.Computations;

namespace MathLibrary.Objects
{
    public class Box : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public double Volume()
        {
            return ComputationManager.Volume(this);
        }

        public double Area() //This is the surface area for the box
        {
            return ComputationManager.Area(this);
        }
    }
}
