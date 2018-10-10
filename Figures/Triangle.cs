using System;
using System.Linq;

namespace Figures
{
    public class Triangle : IFigure
    {
        private readonly double[] _sides;

        public Triangle(double side1, double side2, double side3)
        {
            _sides = new double[] { side1, side2, side3 };
        }

        public double Square()
        {
            double halfMeter = _sides.Sum(s => s) / 2;
            return Math.Pow(halfMeter * _sides.Select(s => halfMeter - s).Aggregate((p, x) => p *= x), 0.5);
        }

        public bool IsRectangular()
        {
            double[] sortedSides = _sides.OrderBy(s => s).ToArray();
            return Math.Pow(sortedSides[2], 2) ==
                Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2);
        }
    }
}
