using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace UnitTestProject
{
    [TestClass]
    public class UnknownFigureTest
    {
        [TestMethod]
        public void UnknownFigureTest_Square()
        {
            UnknownFigure figure = new UnknownFigure();
            Assert.AreEqual(6, figure.Square(r => { return 2 * 3; }));
        }
    }
}