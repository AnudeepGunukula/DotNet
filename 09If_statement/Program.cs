using System;

namespace If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number: ");

            int UserNumber = int.Parse(Console.ReadLine());


            // the below code block checks every if condition even one becomes true 

            if(UserNumber==1)
            {
                Console.WriteLine("Your number is one");
            }
            if(UserNumber==2)
            {
                Console.WriteLine("Your number is two");
            }
            if(UserNumber==3)
            {
                Console.WriteLine("Your number is three");
            }
            if(UserNumber!=1 && UserNumber!=2 && UserNumber!=3)
            {
                Console.WriteLine("your number is not in 1,2,3");
            }



            // mutually exclusive so wont check other if one get true.  also fast
            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
            else if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }
            else
            {
                Console.WriteLine("Your number is not in 1,2,3");
            }



            //  if(condition 1 || condition2)     || will stop at condition1 and enters if block if condition1 is true

            //  if(condition 1 | condition2)       | will run both condition 1,2  ( little slow)

            // similary with && and & but the only difference is && stops if condition 1 is false
        }

    }
}
