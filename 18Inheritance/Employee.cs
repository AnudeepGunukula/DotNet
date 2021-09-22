using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Inheritance
{
    class Employee
    {
        public string FirstName;
        public string LastName;


        public Employee()
        {
            Console.WriteLine("parent class employee constructor");
        }
        public void PrintFullName()
        {
            Console.WriteLine($"full name is {FirstName} {LastName}");
        }
        public Employee(string Message):this()         // calls the default constructor from this parameterised constructor and then get back here and prints
        {
            
            Console.WriteLine($"message : {Message}");
        }
    }

   
}
