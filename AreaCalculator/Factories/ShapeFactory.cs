using AreaCalculator.Interfaces;

namespace AreaCalculator.Factories
{
    public abstract class ShapeFactory
    {
        /// <summary>
        /// Get a shape
        /// </summary>
        /// <returns>Shape</returns>
        public abstract IShape GetShape();
    }
}
