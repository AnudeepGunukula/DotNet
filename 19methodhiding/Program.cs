using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19methodhiding
{
    class Program
    {
        static void Main(string[] args)
        {


            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "john";
            fte.LastName = "snow";
            fte.PrintFullName();
            
            
            PartTimeEmployee pte = new PartTimeEmployee();

            pte.FirstName = "Arya";
            pte.LastName = "Stark";

            pte.PrintFullName();
             
           ((Employee)pte).PrintFullName();             // converting derived class instance to base class instance will get his methods even if hided by derived class

            Employee emp;

            emp = new PartTimeEmployee();

            emp.PrintFullName();           // here printfullname() method is parent class method only bcz parent class cant acces pure childs methods 

        }
    }
}
