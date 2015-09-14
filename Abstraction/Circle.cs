using System;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public virtual double Radius { get; set; }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
