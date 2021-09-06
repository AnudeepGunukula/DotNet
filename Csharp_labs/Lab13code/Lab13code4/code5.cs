using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace Lab13code4
{
    class code5
    {
        static void Main(string[] args)
        {
            ArrayList sarr = new ArrayList();
            Supplier sobj;
            while (true)
            {
                Console.WriteLine("1)Add Supplier in list");
                Console.WriteLine("2)serialize the list in json format");
                Console.WriteLine("3)Quit");
                Console.Write("Enter your option:");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 1 || x > 2)
                {
                    break;
                }
                switch (x)
                {
                    case 1:
                        sobj = new Supplier();
                        Supplier.AcceptDetails(sobj);
                        sarr.Add(sobj);
                        Console.WriteLine("Succesfully added record to list");
                        break;
                    case 2:
                        FileStream fs = new FileStream("supplier.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        JsonSerializer js = new JsonSerializer();
                        StreamWriter sw = new StreamWriter(fs);
                        js.Serialize(sw, sarr);
                        Console.WriteLine("Succesfully serialized in json format");
                        sw.Close();
                        fs.Close();



                        break;
                    default:
                        break;

                }
            }
        }
    }
}
