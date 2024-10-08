using AreaCalculator.Factories;

namespace AreaCalculator
{
    internal static class FactoryCreator
    {
        /// <summary>
        /// Get a factory which will be initialize the object
        /// </summary>
        /// <param name="parametrs"></param>
        /// <returns>Get a factory</returns>
        /// <exception cref="ArgumentException"></exception>
        public static ShapeFactory CreateFactory(params double[] sides)
        {
            //There we can add a new factories
            switch (sides.Length)
            {
                case 1:
                    return new CircleFactory(sides[0]);
                case 3:
                    return new TriangleFactory(sides[0], sides[1], sides[2]);
                default:
                    throw new ArgumentException("Неизвестный тип фигуры");
            }
        }
    }
}
