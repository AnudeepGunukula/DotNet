using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27MultipleInheritance_with_Interfaces
{


    interface IA
    {
        void Amethod();
    }

    class A : IA
    {
        public void Amethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();

    }

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }


    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void Amethod()
        {
            a.Amethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.Amethod();
            ab.BMethod();
        }
    }
}
