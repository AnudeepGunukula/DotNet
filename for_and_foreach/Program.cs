using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_and_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];

            for(int i=0;i<Numbers.Length;i++)        // when known how many times to run loop then use this otherwise use while
            {
               Console.WriteLine(Numbers[i]);
            }
        }
    }
}
