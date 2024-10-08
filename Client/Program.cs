using AreaCalculator;
try
{
    var shape = ShapeCreator.CreateShape(4);
    Console.WriteLine(shape.CalculateArea());
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
