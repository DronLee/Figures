using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace UnitTestProject
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Circle_Constructor_IncorrectRadius()
        {
            foreach (var radius in new double[] { -1, 0 })
                try
                {
                    Circle circle = new Circle(radius);
                    throw new Exception(string.Format(
                        "Для радиуса \"{0}\" должно было возникнуть исключение.", radius));
                }
                catch (IncorrectFigure exc)
                {
                    Assert.AreEqual("Радиус должен быть больше нуля.", exc.Message,
                        "Возникла не та ошибка.");
                }
        }

        [TestMethod]
        public void Circle_Square()
        {
            const double radius = 2.5;
            Circle circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.Square());
        }
    }
}