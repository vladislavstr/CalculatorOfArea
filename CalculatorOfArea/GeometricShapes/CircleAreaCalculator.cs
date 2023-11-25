namespace CalculatorOfArea.GeometricShapes
{
    /// <summary>
    /// Implementation of the Circle area calculator.
    /// </summary>
    /// /// <param name="radius">The radius number.</param>
    /// <returns>Circle area.</returns>
    public class CircleAreaCalculator : IAreaCalculator
    {
        private double radius;

        public CircleAreaCalculator(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
