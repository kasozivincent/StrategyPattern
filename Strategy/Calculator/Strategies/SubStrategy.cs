namespace Calculator
{
    public class SubStrategy : IArithmeticOperation
    {
        public double Compute(double first, double second)
            => first - second;
    }
}