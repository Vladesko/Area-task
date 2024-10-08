using AreaCalculator.Interfaces;

namespace AreaCalculator.Domain
{
    internal class Circle : IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус не может быть меньше или равным 0");

            _radius = radius;
        }
        /// <summary>
        /// Calculate of area of cyrcle
        /// </summary>
        /// <returns>Area of circle</returns>
        public double CalculateArea() =>
            Math.PI * Math.Pow(_radius, 2);
    }
}
