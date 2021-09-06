using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylogic1
{
    public class PermanentEmployee : Employee
    {
        private int NoOfLeaves;
        private double ProvidendFund;

        public int NoOfLeaves1 { get => NoOfLeaves; set => NoOfLeaves = value; }
        public double ProvidendFund1 { get => ProvidendFund; set => ProvidendFund = value; }

        public override void GetSalary()
        {
            Salary1 = Salary1 - ProvidendFund;
        }
    }
}
