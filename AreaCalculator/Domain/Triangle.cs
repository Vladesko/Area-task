using AreaCalculator.Interfaces;

namespace AreaCalculator.Domain
{
    internal class Triangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;
        public Triangle(double a, double b, double c)
        {
            if (!IsValidSides(a, b, c))
                throw new ArgumentException("Данные введены неверно");

            _a = a;
            _b = b;
            _c = c;
        }
        /// <summary>
        /// Calculate of area of triangle
        /// </summary>
        /// <returns>Area of triangle</returns>
        public double CalculateArea()
        {
            if (IsRightTriangle(_a, _b, _c))
                return GetAreaFromRightTriangle(_a, _b);

            return GetAreaFromNotRightTriangle(_a, _b, _c);
        }
        /// <summary>
        /// Get a area of triangle by Geron`s formula 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Area of a triangle</returns>
        private double GetAreaFromNotRightTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        /// <summary>
        /// Get a square of right triangle
        /// </summary>
        /// <param name="firstCatet"></param>
        /// <param name="secondCatet"></param>
        /// <returns>Square of right triangle</returns>
        private double GetAreaFromRightTriangle(double firstCatet, double secondCatet) =>
            firstCatet * secondCatet / 2;

        /// <summary>
        /// Сhecking whether a triangle is right-angled
        /// </summary>
        /// <param name="firstCatet"></param>
        /// <param name="secondCatet"></param>
        /// <param name="hypotenuse"></param>
        /// <returns>false if triangle is not right</returns>
        private bool IsRightTriangle(double firstCatet, double secondCatet, double hypotenuse)
        {
            // Проверка на прямоугольный треугольник по теореме Пифагора
            double[] sides = { firstCatet, secondCatet, hypotenuse };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
        /// <summary>
        /// Checking whether a triangle is valid
        /// </summary>
        /// <param name="firstCatet"></param>
        /// <param name="secondCatet"></param>
        /// <param name="hypotenuse"></param>
        /// <returns>false if sides are not valid</returns>
        private bool IsValidSides(double a, double b, double c)
        {
            // Проверка на существование треугольника и валидность его данных
            if (a <= 0 ||
                b <= 0 ||
                c <= 0 ||
                a + b <= c ||
                a + c <= b ||
                b + c <= a)
                return false;

            return true;
        }
    }
}
