using System;

namespace Calculator
{
    public class Calculator
    {

        public Calculator()
        {
        }

        public double Compute(double first, double second, char operation)
        {
            if(operation == '+')
                return first + second;
            else if(operation == '-')
                return first - second;
            else if(operation == '*')
                return first * second;
            else if(operation == '/')
            {
                if(second != 0)
                    return first / second;
                else
                    throw new DivideByZeroException();
            }
            else
                throw new InvalidOperationException();
        }
    }
}