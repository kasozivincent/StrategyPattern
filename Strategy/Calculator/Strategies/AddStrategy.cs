namespace Calculator
{
    public class AddStrategy : IArithmeticOperation
    {
        public double Compute(double first, double second)
          => first + second; 
    }
}