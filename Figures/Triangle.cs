using System;
using System.Linq;

namespace Figures
{
    public class Triangle : IFigure
    {
        private readonly double[] _sortedSides;

        public Triangle(double side1, double side2, double side3)
        {
            _sortedSides = new double[] { side1, side2, side3 }.OrderBy(s => s).ToArray();
            if (_sortedSides.Any(s => s <= 0))
                throw new Exception("Все стороны должны быть больше нуля.");
            if (_sortedSides[2] >= _sortedSides[0] + _sortedSides[1])
                throw new Exception("Ни одна из сторон не должна превышать сумму двух других.");
        }

        public double Square()
        {
            double halfMeter = _sortedSides.Sum(s => s) / 2;
            return Math.Pow(halfMeter *
                _sortedSides.Select(s => halfMeter - s).Aggregate((p, x) => p *= x), 0.5);
        }

        public bool IsRectangular()
        {
            return Math.Pow(_sortedSides[2], 2) ==
                Math.Pow(_sortedSides[0], 2) + Math.Pow(_sortedSides[1], 2);
        }
    }
}
