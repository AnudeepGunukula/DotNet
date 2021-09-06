using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10code
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second number:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Multiplication");
            Console.WriteLine("3)Division");
            Console.WriteLine("4)Subtraction");
            Console.WriteLine("5)Max number");
            Console.WriteLine("Enter the number of arithmetic operation to perform:");
            int c = Convert.ToInt32(Console.ReadLine());
            ArithmeticOperation aobj = new ArithmeticOperation();
            mydelegate md;
            if (c == 1)
            {
                md = aobj.Add;
                Console.WriteLine($"the addition of {a} and {b} is {md(a, b)}");
            }
            else if (c == 2)
            {
                md = aobj.Multiply;
                Console.WriteLine($"the Muliplication of {a} and {b} is {md(a, b)}");
            }
            else if (c == 3)
            {
                md = aobj.Divide;
                Console.WriteLine($"the Division of {a} and {b} is {md(a, b):F2}");
            }
            else if (c == 4)
            {
                md = aobj.Subtract;
                Console.WriteLine($"the Subtraction of {a} and {b} is {md(a, b)}");
            }
            else if (c == 5)
            {
                md = aobj.Max;
                Console.WriteLine($"the Max number between {a} and {b} is {md(a, b)}");
            }

            else
            {
                Console.WriteLine("Enter only in range [1-5]");
            }



        }


    }

}
