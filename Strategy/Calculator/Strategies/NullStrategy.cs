namespace Calculator
{
    public class NullStrategy : IArithmeticOperation
    {
        public double Compute(double first, double second)
        {
            return 0.0;
        }
    }
}