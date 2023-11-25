using CalculatorOfArea.GeometricShapes;

namespace CalculatorOfArea
{
    public class AreaCalculatorFactory : IAreaCalculatorFactory
    {
        public IAreaCalculator Create(double[] parameters)
        {

            if (parameters.Length == 1)
            {
                return new CircleAreaCalculator(parameters[0]);
            }
            if (parameters.Length == 3)
            {
                return new TriangleAreaCalculator(parameters[0], parameters[1], parameters[2]);
            }
            else
            {
                throw new ArgumentException("Неверное количество параметров для подсчета площади круга или треугольника");
            }
        }
    }
}
