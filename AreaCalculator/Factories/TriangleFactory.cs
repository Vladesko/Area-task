using AreaCalculator.Domain;
using AreaCalculator.Interfaces;

namespace AreaCalculator.Factories
{
    internal class TriangleFactory : ShapeFactory
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        public TriangleFactory(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public override IShape GetShape()
        {
            return new Triangle(_a, _b, _c);
        }
    }
}
