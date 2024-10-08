using AreaCalculator;
try
{
    var shape = ShapeCreator.CreateShape(Math.PI);
    Console.WriteLine(shape.CalculateArea());
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
