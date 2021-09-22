using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Classes
{
    class Program                           // classes are used to create complex custom types (advanced structures)
    { 
        static void Main(string[] args)
        {

            Customer c1 = new Customer("hello","world");      // instance creation

            c1.PrintFullName();

            Customer c2 = new Customer("hello", "mars");

            c2.PrintFullName();
        }
    }


    class Customer
    {
       public string firstname = string.Empty;
       public string lastname = string.Empty;
        
        public Customer()        // constructor used to init the variables
        {

        }

        public Customer(string FirstName,string LastName)            //parameterized constructor
        {
            this.firstname = FirstName;
            this.lastname = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"fullname = {firstname} {lastname}");
        }

        ~Customer()       // destructor to clean resources
        {

        }

    }
}
