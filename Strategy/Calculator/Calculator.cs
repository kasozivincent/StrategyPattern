using System;

namespace Calculator
{
    public class Calculator
    {
        private IArithmeticOperation operation;

        public Calculator(IArithmeticOperation operation)
            => this.operation = operation;

        public double Compute(double first, double second)
            => operation.Compute(first, second);

    }
}