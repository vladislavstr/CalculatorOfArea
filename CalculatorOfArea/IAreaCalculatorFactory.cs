namespace CalculatorOfArea
{
    public interface IAreaCalculatorFactory
    {
        IAreaCalculator Create(double[] parameters);
    }
}
