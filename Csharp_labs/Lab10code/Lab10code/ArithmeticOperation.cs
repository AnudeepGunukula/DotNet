using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10code  //code 2 included
{
    public delegate double mydelegate(double a, double b);
    class ArithmeticOperation
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return (a / b);
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Max(double a, double b)
        {
            return a >= b ? a : b;
        }

    }
}
