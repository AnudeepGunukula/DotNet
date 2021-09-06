using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2code3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] starr = new string[5];
            Console.WriteLine("Enter the names of the cities : ");

            for (int i = 0; i < 5; i++)
            {
                starr[i] = Console.ReadLine();
            }
            Console.WriteLine("The city names you entered are : ");
            foreach (string st in starr)
            {
                Console.WriteLine(st);
            }

        }
    }
}
