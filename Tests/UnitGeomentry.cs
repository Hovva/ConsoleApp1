using GeometryLibrary;
using NUnit.Framework;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class FigureCalculatorTests
    {
        private const double eps = 1e-5;
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            double actualArea = FigureCalculator.CalculateArea(FigureType.Circle, radius);

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(eps)); 
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;
            double actualArea = FigureCalculator.CalculateArea(FigureType.Triangle, sideA, sideB, sideC);

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(eps));
        }

        [Test]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void IsRightTriangle_InvalidRightTriangle_ReturnsFalse()
        {
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [Test]
        public void CalculateArea_InvalidParameters_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FigureCalculator.CalculateArea(FigureType.Circle));
            Assert.Throws<ArgumentException>(() => FigureCalculator.CalculateArea(FigureType.Triangle, 3, 4));
        }

        [Test]
        public void CalculateArea_InvalidParameters_ThrowException()
        {
            Assert.Throws<Exception>(() =>
            {
                var triangle = new Triangle(1, 2, 15);
            });
        }
    }
}