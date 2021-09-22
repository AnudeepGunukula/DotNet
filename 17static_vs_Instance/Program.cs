using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17static_vs_Instance
{


    class Circle                          // instance have their own copy in heap where as static is stored in data segement and is same for all instances
    {

        static float pi;
        int radius;

        public Circle()
        {

        }
        static Circle()        // static constructor is the first constructor to be called and only called once
        {
            pi = 3.14F;
        }

        public Circle(int Radius)
        {
            this.radius = Radius;
        }

        public  float CalcArea()
        {
            return Circle.pi * radius * radius;
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {

            Circle c1 = new Circle(5);
            Console.WriteLine($"area of circle c1 is {c1.CalcArea()}");
        }
    }
}
