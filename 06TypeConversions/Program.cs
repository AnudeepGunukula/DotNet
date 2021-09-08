using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = i;          // implicit conversion happens if there is no loss of information


            Console.WriteLine(f);

            float ff = 4434.43F;
            float fx = ff;
             
            int x = (int) ff;            //implicit conversion raise error bcz loss of information so we use explicit conversion using typecasting


            int y = Convert.ToInt32(x);   // type conversion using covert class


            Console.WriteLine(y);
            Console.WriteLine(x);


            string num = "999adf";
            int a;

            // a = int.Parse(num);
            //Console.WriteLine(a);

            // parsing fails then exception will raise

            // try parsing and fail of it wont raise exception
            // return type is bool
            bool isconv_success = int.TryParse(num, out a);
            Console.WriteLine(isconv_success);
            Console.WriteLine(a);


        }
    }
}
