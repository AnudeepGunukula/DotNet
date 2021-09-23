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

        public virtual void PrintFullName()
        {
            Console.WriteLine($"fullname is : {FirstName}  {LastName}");
        }

    }

    class PartTimeEmployee : Employee
    {

        public override void PrintFullName()
        {
            Console.WriteLine($"fullname is : {FirstName} {LastName} - parttime");
        }
    }


    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"fullname is : {FirstName} {LastName} - Fulltime");
        }

    }

    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"fullname is : {FirstName} {LastName} - temporary");
        }
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


            // polymorphism, enables to invoke derived class methods through base class reference variable at runtime

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
