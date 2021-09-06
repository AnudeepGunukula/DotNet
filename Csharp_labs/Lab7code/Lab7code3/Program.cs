using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7logic3;

namespace Lab7code3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lemp = new List<Employee>();
            Employee emp;
            while (true)
            {
                Console.WriteLine("1)Adding new Employee");
                Console.WriteLine("2)search in records");
                Console.WriteLine("3)Delete a record");
                Console.WriteLine("4)view all records");
                Console.WriteLine("5)Quit");
                Console.Write("Enter the option:");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 1 || i > 4)
                {
                    break;
                }
                switch (i)
                {
                    case 1:
                        emp = new Employee();
                        Console.Write("Enter the Employee Number:");
                        emp.EmpNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Employee Name:");
                        emp.EmpName = Console.ReadLine();
                        Console.Write("Enter the Employee Salary:");
                        emp.EmpSal = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the Employee PF:");
                        emp.EmpPf = Convert.ToDouble(Console.ReadLine());
                        lemp.Add(emp);
                        break;
                    case 2:
                        Console.Write("Enter the Emp number to search in Records:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int flag = 0;
                        foreach (var inst in lemp)
                        {
                            if (inst.EmpNo == x)

                            {
                                Console.WriteLine("Record Found");
                                Console.WriteLine($"The Employee number is {inst.EmpNo} ");
                                Console.WriteLine($"The Employee Name is {inst.EmpName} ");
                                Console.WriteLine($"The Employee salary is {inst.EmpSal} ");
                                Console.WriteLine($"The Employee Pf is {inst.EmpPf} ");
                                flag = 1;
                            }
                        }
                        if (flag == 0)
                        {
                            Console.WriteLine("Record not found");
                        }
                        break;
                    case 3:
                        Console.Write("Enter the Emp number you want to delete in Records:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        int flags = 0;
                        for (int n = 0; n < lemp.Count; n++)
                        {
                            if (lemp[n].EmpNo == y)

                            {
                                Console.WriteLine($"Succesfully deleted {lemp[n].EmpName} record");
                                lemp.RemoveAt(n);

                                flags = 1;
                            }
                        }
                        if (flags == 0)
                        {
                            Console.WriteLine("Record not found");
                        }

                        break;
                    case 4:
                        foreach (var inst in lemp)
                        {
                            Console.WriteLine($"The Employee number is {inst.EmpNo} ");
                            Console.WriteLine($"The Employee Name is {inst.EmpName} ");
                            Console.WriteLine($"The Employee salary is {inst.EmpSal} ");
                            Console.WriteLine($"The Employee Pf is {inst.EmpPf} ");
                            Console.WriteLine("=====================================");
                        }

                        break;
                    default:
                        break;



                }
            }

        }
    }
}
