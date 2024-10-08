using AreaCalculator.Domain;
using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Factories
{
    internal class CircleFactory : ShapeFactory
    {
        private readonly double _radius;
        public CircleFactory(double radius)
        {
            _radius = radius;
        }
        public override IShape GetShape()
        {
            return new Circle(_radius);
        }
    }
}
