using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Inheritance
{
    class PartTImeEmployee:Employee
    {

        public float HourlyRate;

        public PartTImeEmployee() : base("parttime constructor calling paramerter constructor in base class")
        {
            Console.WriteLine("part time employee constructor");
        }

        
    }
}
