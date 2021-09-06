using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2code1
{
    class Program
    {

        struct Structure
        {
            public int Number;
            public void square()
            {
                Console.WriteLine(Number * Number);
            }
            public void cube()
            {
                Console.WriteLine(Number * Number * Number);
            }
        }

        static void Main(string[] args)
        {
            Structure st;
            Console.Write("Enter a number : ");
            st.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Display Square");
            Console.WriteLine("2.Display Cube");
            Console.Write("Enter a number : ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                st.square();
            }
            if (i == 2)
            {
                st.cube();
            }


        }
    }
}
