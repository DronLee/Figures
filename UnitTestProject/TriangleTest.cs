using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace UnitTestProject
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_Constructor_NegativeValue()
        {
            List<double[]> sidesList = new List<double[]>();
            foreach (var side in new double[] { -1, 0 })
            {
                sidesList.Add(new double[] { side, 2, 2 });
                sidesList.Add(new double[] { 2, side, 2 });
                sidesList.Add(new double[] { 2, 2, side });
            }
            foreach (var sides in sidesList)
                try
                {
                    Triangle circle = new Triangle(sides[0], sides[1], sides[2]);
                    throw new Exception(string.Format(
                        "Для размеров \"{0}\" должно было возникнуть исключение.",
                        string.Join(",", sides.Select(s => s.ToString()))));
                }
                catch (IncorrectFigure exc)
                {
                    Assert.AreEqual("Все стороны должны быть больше нуля.", exc.Message,
                        "Возникла не та ошибка.");
                }
        }

        [TestMethod]
        public void Triangle_Constructor_BigSide()
        {
            List<double[]> sidesList = new List<double[]>();
            sidesList.Add(new double[] { 4, 2, 2 });
            sidesList.Add(new double[] { 2, 4, 2 });
            sidesList.Add(new double[] { 2, 2, 4 });
            foreach (var sides in sidesList)
                try
                {
                    Triangle circle = new Triangle(sides[0], sides[1], sides[2]);
                    throw new Exception(string.Format(
                        "Для размеров \"{0}\" должно было возникнуть исключение.",
                        string.Join(",", sides.Select(s => s.ToString()))));
                }
                catch (IncorrectFigure exc)
                {
                    Assert.AreEqual("Ни одна из сторон не должна превышать сумму двух других.",
                        exc.Message, "Возникла не та ошибка.");
                }
        }

        [TestMethod]
        public void Triangle_Square()
        {
            Triangle triangle = new Triangle(4, 4, 6);
            Assert.AreEqual(Math.Pow(63, 0.5), triangle.Square());
        }

        [TestMethod]
        public void Triangle_IsRectangular()
        {
            Triangle triangle = new Triangle(4, 3, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }

        [TestMethod]
        public void Triangle_IsNotRectangular()
        {
            Triangle triangle = new Triangle(5, 3, 5);
            Assert.IsFalse(triangle.IsRectangular());
        }
    }
}