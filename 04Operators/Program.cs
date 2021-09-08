using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;         //assignment op

            int a = 10, b = 20;

            int sum = a + b;    // sum op
            Console.WriteLine(sum);

            int dif = a - b;     // diff op
            Console.WriteLine(dif);

            int div = a / b;     // div op
            Console.WriteLine(div);

            int mul = a * b;     // mul op
            Console.WriteLine(mul);

            int remainder = a % b;       // modulo op
            Console.WriteLine(remainder);

            // similary we have  comparision op  == , != , >= , <= 

            // conditional op  &&, ||


            // ternary op
            int x = a > b ? 100 : 200;

            Console.WriteLine(x);






        } 
    }
}
