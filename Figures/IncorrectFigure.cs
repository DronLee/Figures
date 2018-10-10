using System;

namespace Figures
{
    public class IncorrectFigure : Exception
    {
        public IncorrectFigure(string message) : base(message) { }
    }
}