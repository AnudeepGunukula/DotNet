using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Methodoverriding_vs_methodhiding
{


    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am base class print method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a derived class print method");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            BaseClass b = new DerivedClass();
            b.Print();              // in method hiding this line will call base class print method
                                    // because we are using base class reference variable
        }
    }
}
