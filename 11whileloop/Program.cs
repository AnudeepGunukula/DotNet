using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target: ");
            int UserTarget = int.Parse(Console.ReadLine());
            int start = 0;
            while(start<=UserTarget)
            {
                Console.Write(start+" ");
                start += 2;
            }
        }
    }
}
