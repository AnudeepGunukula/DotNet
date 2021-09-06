using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogic;

namespace Lab1
{
    class Program
    {
        public static void EmpDetails(Employee e)
        {
            Console.WriteLine($"enter the employee Id : ");
            e.EmployeeId1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"enter the employee Name : ");
            e.EmployeeName1 = Console.ReadLine();
            Console.WriteLine($"enter the employee Address : ");
            e.Address1 = Console.ReadLine();
            Console.WriteLine($"enter the employee City : ");
            e.City1 = Console.ReadLine();
            Console.WriteLine($"enter the employee Department: ");
            e.Department1 = Console.ReadLine();
            Console.WriteLine($"enter the employee Salary : ");
            e.Salary1 = Convert.ToDouble(Console.ReadLine());
        }
        public static void Display(Employee e)
        {
            Console.WriteLine($"the employee name is : {e.EmployeeName1}");
            Console.WriteLine($"the employee salary is : {e.Salary1}");
        }
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[10];

            for (int i = 0; i < 10; i++)
            {
                emp[i] = new Employee();
                EmpDetails(emp[i]);
            }
            for (int j = 0; j < 10; j++)
            {
                Display(emp[j]);
            }



        }
    }
}
