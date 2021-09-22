using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19methodhiding
{
    class Employee
    {
        public string FirstName;
        public string LastName;


        public void PrintFullName()
        {
            Console.WriteLine($"full name is {FirstName} {LastName}");
        }
    }
}
