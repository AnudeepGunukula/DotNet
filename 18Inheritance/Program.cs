using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();       // parent class constructors are called before child class constructors

            fte.FirstName = "jack";
            fte.LastName = "sparrow";
            fte.YearlySalary = 5000000;
            fte.PrintFullName();


            PartTImeEmployee pte = new PartTImeEmployee();
            pte.FirstName = "john";
            pte.LastName = "snow";
            pte.HourlyRate = 20000;
            pte.PrintFullName();


        }
    }
}
