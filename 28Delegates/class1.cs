using System;
using System.Collections.Generic;
namespace _28Delegates
{
    public delegate bool IsPromoted(Employee emp);
    // delegates are used to pass the function pointer to other function
    public class class1
    {

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101, Name = "tonystark", Salary = 30000, Experience = 7 });
            empList.Add(new Employee() { Id = 102, Name = "Aryastark", Salary = 80000, Experience = 4 });

            IsPromoted isPromoted = Promote;
            Employee.PromoteEmployee(empList, isPromoted);
            // we can also use lambda expressions here instead of passing delegate
            // Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);

        }

    }



    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> EmployeeList, IsPromoted isPromoted)
        {
            foreach (Employee emp in EmployeeList)
            {
                if (isPromoted(emp))
                {
                    Console.WriteLine(emp.Name + " Promoted.");
                }
            }
        }

    }
}