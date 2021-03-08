using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArithmeticOps;
namespace ArithCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Operations op = new Operations();
            Console.WriteLine($"the Addition of {a} and {b} is {op.Add(a, b)}");
            Console.WriteLine($"the Subtraction of {a} and {b} is {op.Subtract(a, b)}");
            Console.WriteLine($"the Multiplication of {a} and {b} is {op.Multiply(a, b)}");
            Console.WriteLine($"the Division of {a} and {b} is {op.Divide(a, b)}");
            Console.WriteLine($"the Modulus of {a} and {b} is {op.Modulus(a, b)}");


        }
    }
}

