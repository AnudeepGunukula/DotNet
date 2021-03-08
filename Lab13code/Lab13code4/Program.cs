using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab13code4
{
    class Program // make this as startup for code 4 testing
    {
        static void Main(string[] args)
        {
            Supplier s = new Supplier();
            Supplier.AcceptDetails(s);
            FileStream fs = new FileStream("supplier.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Supplier));
            xs.Serialize(fs, s);
            Console.WriteLine("Succesfully performed xml serialization");
            fs.Close();




        }
    }
}
