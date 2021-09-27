using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26AbstractClass
{

    abstract class Customer                 //abstract class cant be sealed
    {                                      // abstract class may contain abstract methods but not mandatory
        public void print()
        {
            Console.WriteLine("normal print is implemented");
        }

        public abstract void print2();

    }

    class Program : Customer
    {
        public override void print2()
        {
            Console.WriteLine("abstract print2 is implemented");
        }

        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.print();
            pg.print2();

        }

    }
}
