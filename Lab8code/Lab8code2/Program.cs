using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab8code2
{
    class Program
    {
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }
        static void Main()
        {
            Hashtable myhash = GetHashtable();
            Console.WriteLine(myhash.ContainsKey("Perimeter"));
            Console.WriteLine(myhash["Area"]);
            myhash.Remove("Mortgage");
            Console.WriteLine("Succesfully Deleted Mortgage");


        }

    }
}
