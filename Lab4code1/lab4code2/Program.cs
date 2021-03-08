using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4code2
{

    public class Shape
    {
        public virtual void WhoamI()
        {
            Console.WriteLine("I m Shape");
        }
    }

    public class Triangle : Shape
    {
        public override void WhoamI()
        {
            Console.WriteLine("I m Triangle");
        }
    }


    public class Circle : Shape
    {
        public override void WhoamI()
        {
            Console.WriteLine("I m Circle");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Triangle();
            s.WhoamI();
            s = new Circle();
            s.WhoamI();
        }

    }
}
