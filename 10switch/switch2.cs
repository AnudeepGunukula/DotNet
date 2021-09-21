using System;
using System.Collections.Generic;
using System.Text;

namespace _10switch
{

    class switch2
    {
        static void Main(string[] args)
        {

             int TotalCoffeeCost = 0;
        start:                                                                       // start is a label
           
            Console.WriteLine("Please select your coffee size: 1-small, 2-medium, 3-Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine($"Your choice {userChoice} is invalid");
                    goto start;

            }

            Ask:
            Console.WriteLine("Will you want to buy another coffee ?  Y/N");
            char Choice = Console.ReadLine().ToUpper()[0];

            switch (Choice)
            {
                case 'Y':
                    goto start;                                                   // goto is similar to goto in c and jmp in Assembly
                case 'N':                                                         // goto is bad programming style bcz debugging is complex so we use loops
                    Console.WriteLine("Thanks for shopping with us");
                    break;
                default:
                    Console.WriteLine("Invalid input given");
                    goto Ask;

            }


            Console.WriteLine($"Total Bill Amount: {TotalCoffeeCost} $");

        }
    }
}
