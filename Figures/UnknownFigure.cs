using System;

namespace Figures
{
    public class UnknownFigure
    {
        public double Square(Func<UnknownFigure, double> calcMethod)
        {
            return calcMethod.Invoke(this);
        }
    }
}