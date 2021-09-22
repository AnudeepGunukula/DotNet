using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Polymorphism
{


    class Employee
    {

        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine($"fullname is : {FirstName}  {LastName}");
        }

    }

    class PartTimeEmployee : Employee
    {
    }


    class FullTimeEmployee : Employee
    {


    }

    class TemporaryEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();


            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
