using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchUse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            switch (a)
            {
                case 1:
                    Console.WriteLine($"you have entered 1");
                    break;
                case 2:
                    Console.WriteLine($"you have entered 2");
                    break;
                case 3:
                    Console.WriteLine($"you have entered 3");
                    break;
                case 4:
                    Console.WriteLine($"you have entered 4");
                    break;
                case 5:
                    Console.WriteLine($"you have entered 5");
                    break;
                default:
                    Console.WriteLine($"you have entered the number which is not in range [1,5]");
                    break;

            }
        }
    }
}
