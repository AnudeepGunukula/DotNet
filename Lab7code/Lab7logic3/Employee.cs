using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7logic3
{
    public class Employee
    {
        private int empNo;
        private string empName;
        private double empSal;
        private double empPf;

        public int EmpNo { get => empNo; set => empNo = value; }
        public string EmpName { get => empName; set => empName = value; }
        public double EmpSal { get => empSal; set => empSal = value; }
        public double EmpPf { get => empPf; set => empPf = value; }

        public Employee()
        {
        }
        public Employee(int empno, string empname, double empsal, double emppf)
        {
            this.empNo = empno;
            this.empName = empname;
            this.empSal = empsal;
            this.empPf = emppf;
        }


    }
}
