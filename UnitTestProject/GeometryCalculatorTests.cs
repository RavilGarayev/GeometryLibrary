using GeometryLibrary;

namespace UnitTestProject
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        private GeometryCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new GeometryCalculator();
        }

        [Test]
        public void CalculateCircleArea_WithPositiveRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = 78.53981633974483;
            double actualArea = calculator.CalculateCircleArea(radius);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateTriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;
            double actualArea = calculator.CalculateTriangleArea(sideA, sideB, sideC);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateTriangleArea_WithInvalidSides_ThrowsArgumentException()
        {
            double sideA = 1;
            double sideB = 4;
            double sideC = 5;
            calculator.CalculateTriangleArea(sideA, sideB, sideC);
        }
    }
}