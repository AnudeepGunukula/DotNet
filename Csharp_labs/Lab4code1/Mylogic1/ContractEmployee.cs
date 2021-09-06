using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylogic1
{
    public class ContractEmployee : Employee
    {
        private double perks;

        public double Perks { get => perks; set => perks = value; }

        public override void GetSalary()
        {
            Salary1 = Salary1 + perks;
        }
    }
}
