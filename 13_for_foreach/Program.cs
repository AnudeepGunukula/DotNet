using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_for_foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            for(int i=0;i<Numbers.Length;i++)
            {
                Console.WriteLine(Numbers[i]);
            }


            foreach(int i in Numbers)               // we can also use var keyword similar to auto in c++ and var in java
            {
                Console.WriteLine(i);
            }


            for(int i=1;i<100;i++)
            {
                Console.WriteLine(i);
                if (i==10)
                { 
                    break;                                 // breaks the loop
                }
            }

            for(int i=1;i<10;i++)
            {
                if(i%2!=0)
                {
                    continue;                      // continue gets u back to the inc and then to codition
                }
                Console.WriteLine(i);             
            }
        }
    }
}
