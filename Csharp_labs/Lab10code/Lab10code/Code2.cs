using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10code
{
    class Code2 //kindly change startup to this main function for code2 functionality
    {

        static void PerformArithmeticOperation(int a, int b, mydelegate arOp)
        {
            mydelegate md = new mydelegate(arOp);

            Console.WriteLine($"The result of {a} and {b} is {md(a, b)} ");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number :");
            int b = Convert.ToInt32(Console.ReadLine());
            ArithmeticOperation aobj = new ArithmeticOperation();
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Multiplication");
            Console.WriteLine("3)Division");
            Console.WriteLine("4)Subtraction");
            Console.WriteLine("5)Max number");
            Console.WriteLine("Enter the number of arithmetic operation to perform:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                PerformArithmeticOperation(a, b, aobj.Add);
            }
            else if (c == 2)
            {
                PerformArithmeticOperation(a, b, aobj.Multiply);
            }
            else if (c == 3)
            {
                PerformArithmeticOperation(a, b, aobj.Divide);
            }
            else if (c == 4)
            {
                PerformArithmeticOperation(a, b, aobj.Subtract);
            }
            else if (c == 5)
            {
                PerformArithmeticOperation(a, b, aobj.Max);
            }
            else { Console.WriteLine("please enter in range[1-5]"); }
        }
    }
}
