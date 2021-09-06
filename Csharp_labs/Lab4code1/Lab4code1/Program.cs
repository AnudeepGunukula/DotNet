using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mylogic1;

namespace Lab4code1
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
            Console.WriteLine("1)Contract Employee ");
            Console.WriteLine("2)Permanent Employee ");
            Console.Write("Enter the type of employee u are : ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                ContractEmployee cemp = new ContractEmployee();

                EmpDetails(cemp);
                Console.WriteLine("Enter the Perks : ");
                cemp.Perks = Convert.ToDouble(Console.ReadLine());
                cemp.GetSalary();
                Display(cemp);



            }
            else if (i == 2)
            {
                PermanentEmployee pemp = new PermanentEmployee();
                EmpDetails(pemp);
                Console.WriteLine("Enter the Providend Fund : ");
                pemp.ProvidendFund1 = Convert.ToDouble(Console.ReadLine());
                pemp.GetSalary();
                Display(pemp);
            }
            else
            {
                Console.WriteLine("please select from above options ... exiting");
            }



        }
    }
}
