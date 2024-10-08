using AreaCalculator;
using AreaCalculator.Domain;

namespace TestCalculator
{
    public class CommonTests
    {
        [Fact]
        public void CreateTriangleAndCalculateArea_Success()
        {
            //Arrange
            var shape = ShapeCreator.CreateShape(3, 4, 5);
            //Act
            var result = shape.CalculateArea();
            //Assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void CreateCircleAndCalculateArea_Success()
        {
            //Arrange
            var shape = ShapeCreator.CreateShape(1);
            //Act
            var result = shape.CalculateArea();
            //Assert
            Assert.Equal(Math.PI, result);
        }
        [Fact]
        public void CreateShapeWithNotValidSides_Fail()
        {
            //Arrange
            //Act
            //Arrange
            Assert.Throws<ArgumentException>(() => FactoryCreator.CreateFactory(1, 3, 5, 6, 7, 2));
        }
    }
}
