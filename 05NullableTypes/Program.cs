using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 types in c#
            // value types (int,float,double,struct,enums etc)
            // reference types (string,interface, class ,delegate, arrays etc)

            // value types are non nullable by default

            // int i = null;   will raise exception

            string name = null;

            int? i = null;      // will not raise exception

            // ? is used to convert non nullable (value types) to nullable type.

            // makes working with databases easy  

            bool? areYouMajor = null;

            if(areYouMajor==true)
            {
                Console.WriteLine("user is major");
            }
            else if(areYouMajor==false)
            {
                Console.WriteLine("user is not major");
            }
            else
            {
                Console.WriteLine("user is not selected any option");
            }



            // Null coalescing operator

            int? Tickets_on_sale = 100;

            int Avaiable_Tickets;


            if(Tickets_on_sale==null)
            {
                Avaiable_Tickets = 0;
            }
            else
            {
                // Avaiable_Tickets = Tickets_on_sale;          // gives error can't implicitly convert ?int to int

                Avaiable_Tickets = Tickets_on_sale.Value;        //.Value returns the non nullable int part

                Avaiable_Tickets = (int)Tickets_on_sale;        // or we can simply explicitly convert ?int to int

            }


            //or if else code block above can be replaced with single line using Null coalescing operator  ?? 

            Tickets_on_sale = null;

            Avaiable_Tickets = Tickets_on_sale ?? 0;

            Console.WriteLine(Avaiable_Tickets);



        }
    }
}
