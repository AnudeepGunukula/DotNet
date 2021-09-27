using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Interfaces
{

    interface I1
    {

        void InterfaceMethod();

    }


    interface I2
    {
        void InterfaceMethod();
    }

    class ExplicitInterfaces : I1, I2
    {
        void I1.InterfaceMethod()               // explicit interface methods are not having Access modifiers
        {
            Console.WriteLine("interface I1 implemented");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("Interface I2 implemented");
        }
        static void Main(string[] args)
        {
            ExplicitInterfaces obj = new ExplicitInterfaces();
            ((I1)obj).InterfaceMethod();

            ((I2)obj).InterfaceMethod();

            I1 i1 = new ExplicitInterfaces();
            i1.InterfaceMethod();
            I2 i2 = new ExplicitInterfaces();
            i2.InterfaceMethod();

        }

    }
}
