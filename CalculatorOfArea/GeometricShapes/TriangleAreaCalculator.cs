namespace CalculatorOfArea.GeometricShapes
{
    /// <summary>
    /// Implementation of the Triangle area calculator.
    /// </summary>
    /// <param name="sideA">The sideA number.</param>
    /// <param name="sideB">The sideB number.</param>
    /// <param name="sideC">The sideC number.</param>
    /// <returns>Triangle area.</returns>
    public class TriangleAreaCalculator : IAreaCalculator
    {
        private double sideA, sideB, sideC;

        public TriangleAreaCalculator(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        /// <summary>
        /// Implementation of the triangle area calculatr
        /// </summary>
        /// <returns>Value of area</returns>
        public double CalculateArea()
        {
            if (IsRightAngled())
            {

                return sideA * sideB / 2;
            }
            else
            {
                double s = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            }

        }

        /// <summary>
        /// Implementation of checking whether a triangle is rectangular
        /// </summary>
        /// <returns>returns True if the triangle is rectangular</returns>
        private bool IsRightAngled()
        {
            return (sideA * sideA + sideB * sideB == sideC * sideC) ||
               (sideA * sideA + sideC * sideC == sideB * sideB) ||
               (sideB * sideB + sideC * sideC == sideA * sideA);
        }
    }
}
