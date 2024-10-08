using AreaCalculator.Domain;

namespace TestCalculator
{
    public class CircleTests
    {
        [Fact]
        public void CalculateWithValidRadius_Success()
        {
            //Arrange
            var circle = new Circle(1);
            //Act
            var result = circle.CalculateArea();
            //Assert
            Assert.Equal(Math.PI, result);
        }
        [Fact]
        public void CalculateWithNotValidRadius_Fail()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }
}
