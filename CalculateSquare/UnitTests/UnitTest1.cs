using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateSquare;
using Moq;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleSquare()
        {
            double Value = 19.634954084936208;
            Figure figure = new Figure(Type.Circle, 2.5);
            double result = figure.CalculateSquare();
            Assert.AreEqual(Value, result);
        }
        [TestMethod]
        public void TestType()
        {      
            Figure figure = new Figure(Type.Circle, 2.5);
            Type result = figure.GetTypeOfFigure();
            Assert.AreEqual(Type.Circle, result);
        }
        [TestMethod]
        public void TestTriangleSquare()
        {
            double Value = 6;
            Figure figure = new Figure(Type.Triangle, 3,4,5);
            double result = figure.CalculateSquare();
            Assert.AreEqual(Value, result);
        }


        [TestMethod]
        public void TestRightTriangle()
        {
            bool Value = true;
            Figure figure = new Figure(Type.Triangle, 3, 4, 5);
            bool result = figure.IsRightTriangle();
            Assert.AreEqual(Value, result);
        }
    }
}
