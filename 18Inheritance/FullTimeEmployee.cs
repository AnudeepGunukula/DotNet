using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Inheritance
{
    class FullTimeEmployee : Employee       // syntax same as c++ inheritance
    {

        public FullTimeEmployee()
        {
            Console.WriteLine("full time employee constructor");
        }
        public float YearlySalary;
    }
}
