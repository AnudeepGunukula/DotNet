using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            // type,number,order and kind of parameters matters

            Add(1, 2);
            Add(2, 3.4f);
            Add(3.3f, 2);

            int ans = 0;
            Add(5, 6, out ans);
            Console.WriteLine($"Sum : {ans}");

        }

        public static void Add(int Fn, int Sn)
        {
            Console.WriteLine($"Sum : {Fn + Sn}");
        }
        public static void Add(float Fn, int Sn)
        {
            Console.WriteLine($"Sum : {Fn + Sn}");
        }

        public static void Add(int Fn, float Sn)
        {
            Console.WriteLine($"Sum : {Fn + Sn}");
        }

        public static void Add(int Fn, int Sn, out int ans)
        {
            ans = Fn + Sn;
        }
    }
}
