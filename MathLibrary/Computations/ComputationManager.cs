using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary.Objects;

namespace MathLibrary.Computations
{
    public static class ComputationManager
    {
        public static double Volume(Box box)
        {
            return box == null || box.Width < 0 || box.Length < 0 || box.Height < 0 ? Double.NaN : box.Width * box.Length * box.Height;
        }

        public static double Volume(Sphere sphere)
        {
            return sphere == null || sphere.Radius < 0 ? Double.NaN : 4d / 3d * Math.PI * Math.Pow(sphere.Radius, 2);
        }

        public static double Area(Box box)
        {
            return box == null || box.Width < 0 || box.Length < 0 || box.Height < 0 ? Double.NaN : 
                (2d * (box.Width * box.Length)) +
                (2d * (box.Width * box.Height)) +
                (2d * (box.Height * box.Length));
        }

        public static double Area(Sphere sphere)
        {
            return sphere == null || sphere.Radius < 0 ? Double.NaN : 4d * Math.PI * Math.Pow(sphere.Radius, 2d);
        }

        public static double Area(Rectangle rectangle)
        {
            return rectangle == null || rectangle.Width < 0 || rectangle.Height < 0 ? Double.NaN : rectangle.Width * rectangle.Width;
        }

        public static double Area(Circle circle)
        {
            return circle == null || circle.Radius < 0 ? Double.NaN : Math.Pow(2d, circle.Radius) * Math.PI;
        }
    }
}
