using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2code2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 6];
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the elements are");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }


        }
    }
}
