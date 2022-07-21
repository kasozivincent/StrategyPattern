namespace Calculator
{
    public class TestCalculator
    {
        public void Test()
        {
            IArithmeticOperation operation = new SubStrategy();
            Calculator calculator = new Calculator(operation);
            double answer = calculator.Compute(2, 3);
        }
        
    }
}