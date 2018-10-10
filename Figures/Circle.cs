using System;

namespace Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}