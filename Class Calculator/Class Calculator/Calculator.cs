using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculator
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Substract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Ділити на нуль не можна");
            }
            return x / y;

        }
    }
}
