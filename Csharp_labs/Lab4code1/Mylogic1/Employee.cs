using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylogic1
{
    public abstract class Employee
    {
        private int EmployeeId;
        private string EmployeeName;
        private string Address;
        private string City;
        private string Department;
        private double Salary;

        public int EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string City1 { get => City; set => City = value; }
        public string Department1 { get => Department; set => Department = value; }
        public double Salary1 { get => Salary; set => Salary = value; }

        public abstract void GetSalary();
    }
}
