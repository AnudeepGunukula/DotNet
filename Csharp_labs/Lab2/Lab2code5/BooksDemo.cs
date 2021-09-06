using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2code5
{
    class BooksDemo
    {
        string[,] bookDetails = new string[2, 4];
        public BooksDemo()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Book Title : ");
                    }
                    if (j == 1)
                    {
                        Console.Write("Author : ");
                    }
                    if (j == 2)
                    {
                        Console.Write("Publisher : ");
                    }
                    if (j == 3)
                    {
                        Console.Write("Price : ");
                    }
                    bookDetails[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Book Details : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Book Title : ");
                    }
                    if (j == 1)
                    {
                        Console.Write("Author : ");
                    }
                    if (j == 2)
                    {
                        Console.Write("Publisher : ");
                    }
                    if (j == 3)
                    {
                        Console.Write("Price : ");
                    }

                    Console.WriteLine(bookDetails[i, j]);

                }
            }
        }
        static void Main(string[] args)
        {
            BooksDemo Bd = new BooksDemo();
        }
    }
}
