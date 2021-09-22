using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Methods
{
    class Params
    {
        static void Main(string[] args)
        {
            int i = 0;
            SimpleMethod(ref i);              // ref keyword is like &i sending address of i (pass by reference)
            Console.WriteLine(i);


            int sum=0, product=0;
            calculate(20, 20,out sum,out product);

            Console.WriteLine($"sum is {sum} and product is {product}");


            int[] Numbers = { 1, 2, 3 };

            // ParamsMethod();          this wont raise any error bcz params keyword says that argument is optional

            // ParamsMethod(Numbers);

            ParamsMethod(1,6,7,8,9,10);          // this also allowed               

        }

        static void ParamsMethod(int x,params int[] Numbers)                   // but params keyword should be only for the last parameter and only one params per method
        {
            Console.WriteLine($"the x is {x} and remaining all comes under Numbers");
            Console.WriteLine($"there are {Numbers.Length} elements");

            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

        static void SimpleMethod(ref int j)
        {
            j = 101;
        }


        public static void calculate(int fn,int sn,out int sum,out int product)    // use out keyword if you want to return more than one value same as ref only
        {                                                                          // it works the same if you replace out with ref also
            sum = fn + sn;
            product = fn * sn;
        }
    }
}
