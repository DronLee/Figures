using System;
using System.Linq;

namespace Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Стороны треугольника, отсортированные по размеру.
        /// </summary>
        private readonly double[] _sortedSides;

        /// <summary>
        /// Конструкутор.
        /// </summary>
        /// <param name="side1">Сторона 1.</param>
        /// <param name="side2">Сторона 2.</param>
        /// <param name="side3">Сторона 3.</param>
        public Triangle(double side1, double side2, double side3)
        {
            _sortedSides = new double[] { side1, side2, side3 }.OrderBy(s => s).ToArray();
            if (_sortedSides[0] <= 0)
                throw new IncorrectFigure("Все стороны должны быть больше нуля.");
            if (_sortedSides[2] >= _sortedSides[0] + _sortedSides[1])
                throw new IncorrectFigure("Ни одна из сторон не должна превышать сумму двух других.");
        }

        /// <summary>
        /// Вычисление площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double Square()
        {
            double halfMeter = _sortedSides.Sum(s => s) / 2;
            return Math.Pow(halfMeter *
                _sortedSides.Select(s => halfMeter - s).Aggregate((p, x) => p *= x), 0.5);
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True - треугольник прямоугольный.</returns>
        public bool IsRectangular()
        {
            return Math.Pow(_sortedSides[2], 2) ==
                Math.Pow(_sortedSides[0], 2) + Math.Pow(_sortedSides[1], 2);
        }
    }
}