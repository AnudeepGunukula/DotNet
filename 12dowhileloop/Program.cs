using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12dowhileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            char UserChoice;
            do
            {
                Console.Write("enter the target: ");
                int target = int.Parse(Console.ReadLine());
                int start = 0;
                while(start<=target)
                {
                    Console.Write(start + " ");
                    start += 2;
                }
                Console.WriteLine();
                Console.WriteLine("do you want to continue ? Y/N");
                UserChoice = Console.ReadLine().ToUpper()[0];
                if(UserChoice=='N')
                {
                    break;
                }
            }
            while(UserChoice=='Y');

        }
    }
}
