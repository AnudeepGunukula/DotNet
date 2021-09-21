using System;

namespace _10switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userNum = int.Parse(Console.ReadLine());

            switch(userNum)
            {
                case 10:
                    Console.WriteLine("your number is 10");
                    break;
                case 20:                                                             // joining two cases
                case 30:
                    Console.WriteLine($"your number is {userNum}");
                    break;
                default:
                    Console.WriteLine("your number is not 10,20,30");                
                    break;

            }
        }
    }
}
