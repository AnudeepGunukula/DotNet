using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.EvenNumbers(50);
            OddNumbers(50);
            int ans=Program.Add(10, 20);
            Console.WriteLine($"Sum = {ans}");
        }


        static int Add(int fn,int sn)                      // static methods are called with name of class  eg: ClassName.method();
        {                                                 
            return fn + sn;
        }
        public void EvenNumbers(int target)               // instance methods are called with instance of class eg: classObj.method();
        {
            int start = 0;
            while(start<=target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        static void OddNumbers(int target)
        {
            int start = 1;
            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }


    }
}
