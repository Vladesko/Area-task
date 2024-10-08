using AreaCalculator.Domain;

namespace TestCalculator
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateAreaRectangularTriangle_Success()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            //Act
            var result = triangle.CalculateArea();
            //Assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void CalculateAreaNotRectangularTriangle_Success()
        {
            //Arrange
            var triangle = new Triangle(13, 14, 15);
            //Act
            var result = triangle.CalculateArea();
            //Assert
            Assert.Equal(84, result);
        }
        [Fact]
        public void CalculateAreaWithNotValidSides_Fail()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => new Triangle(3, 2, 5));
        }
    }
}
