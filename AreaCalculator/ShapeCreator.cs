using AreaCalculator.Interfaces;

namespace AreaCalculator
{
    public static class ShapeCreator
    {
        /// <summary>
        /// Create a new shape
        /// </summary>
        /// <param name="sides">Sides in santimetrs</param>
        /// <returns>Geometric figure depending on centimetres</returns>
        public static IShape CreateShape(params double[] sides)
        {
            var factory = FactoryCreator.CreateFactory(sides);
            return factory.GetShape();
        }
    }
}
