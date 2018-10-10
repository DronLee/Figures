using System;

namespace Figures
{
    /// <summary>
    /// Неопределённая фигура.
    /// </summary>
    public class UnknownFigure
    {
        /// <summary>
        /// Для самостоятельной реализации расчёта площади фигуры.
        /// </summary>
        /// <param name="calcMethod">Метод расчёта площади фигуры.</param>
        /// <returns>Площадь фигуры.</returns>
        public double Square(Func<UnknownFigure, double> calcMethod)
        {
            return calcMethod.Invoke(this);
        }
    }
}