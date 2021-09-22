using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.TeamA;
using ProjectA.TeamB;
using Aclass = ProjectA.TeamA.TeamAclass;      // aliasing the ambiquity problem with this
using Bclass = ProjectA.TeamB.TeamAclass;

namespace _15Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Aclass.print();                 // by using alias or use fully qualified name "ProjectA.TeamA.TeamAclass.print()"  and "ProjectA.TeamB.TeamAclass.print()" 
            Bclass.print();
        }
    }
}


namespace ProjectA                       // instead of writing in same cs file we can create a class library and add a reference to main project also
{
    namespace TeamA
    {

        class TeamAclass
        {
             public static void print()
            {
                Console.WriteLine("this is team A class");
            }
        }
    }
    namespace TeamB
    {
       class TeamAclass
        {

            public static void print()
            {
                Console.WriteLine("this is team B class");
            }
           
        }

    }

}

