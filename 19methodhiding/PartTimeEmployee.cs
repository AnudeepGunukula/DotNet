using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19methodhiding
{
    class PartTimeEmployee:Employee
    {

        public int hours;
        public new void  PrintFullName()      // reimplement the method of base class and this hides the base class method
        {
            //base.PrintFullName();           // we can call base class properties and methods using base keyword


            Console.WriteLine($"full name: {FirstName} {LastName} - contractor");
        }
    }
}
