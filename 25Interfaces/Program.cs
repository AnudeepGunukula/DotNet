using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Interfaces
{


    interface ICustomer
    {

        // interfaces doesn't have variables
        void Print(string name);      //innterface members are public by default

    }

    interface ICustomer2 : ICustomer
    {
        void Age();

    }


    class Customer : ICustomer2
    {
        public void Age()
        {
            Console.WriteLine("customer Age is 20");
        }

        public void Print(string name)
        {
            Console.WriteLine($"customername: { name} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print("Arjun");
            c1.Age();
        }
    }
}
