using System;
using GeometryLibrary;

namespace GeometryLibraryTests
{
    
    public class ShapeCalculatorTests
    {
        [Fact]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            Circle circle = new Circle(radius);
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 0.0001);
        }

        [Fact]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            // Act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 0.0001);
        }

        [Fact]
        public void CalculateTriangleArea_RightAngledTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            // Act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actualArea = triangle.CalculateArea();
            bool isRightAngledTriangle = triangle.IsRightAngledTriangle();

            // Assert
            Assert.Equal(expectedArea, actualArea, 0.0001);
            Assert.True(isRightAngledTriangle);
        }
    }
}