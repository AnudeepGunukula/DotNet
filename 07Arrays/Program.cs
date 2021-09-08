using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // collection of similar data tpes (strongly typed)
            // main disadvantage is fixed size once init

            int[] arr = new int[5];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;


            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
