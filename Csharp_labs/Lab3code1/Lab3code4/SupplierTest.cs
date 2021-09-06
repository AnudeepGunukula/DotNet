using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3code4
{
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Supplier s1 = new Supplier();
            Supplier.AcceptDetails(s1);
            s1.DisplayDetails();

        }
    }
}
