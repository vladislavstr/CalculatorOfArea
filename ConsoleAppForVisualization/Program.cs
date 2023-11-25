using CalculatorOfArea;

IAreaCalculatorFactory Geometry = new AreaCalculatorFactory();
IAreaCalculator circleCalculator = Geometry.Create(new double[] { 5 });
IAreaCalculator triangleCalculator = Geometry.Create(new double[] { 3, 4, 5 });
Console.WriteLine($"Площадь круга: {circleCalculator.CalculateArea()}");
Console.WriteLine($"Площадь треугольника: {triangleCalculator.CalculateArea()}");