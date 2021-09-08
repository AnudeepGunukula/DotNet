using System;

namespace ReadWriteInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your Name: ");
            string username = Console.ReadLine();

            Console.WriteLine($"Hello {username} your id is {id}");

            Console.WriteLine("Hello {0} your id is {1}", username, id);        //both give same output

            
        }
    }
}
