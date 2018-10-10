using System;

namespace Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IFigure
    {
        private readonly double _radius;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Радиус должен быть больше нуля.");
            _radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}