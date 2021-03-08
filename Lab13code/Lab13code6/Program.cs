using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Lab13code6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sd = new Student(1, "ria", "mumbai", "btech");
            FileStream fs = new FileStream("student.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sd);
            Console.WriteLine("successfully done binary serialization");
            fs.Close();
        }
    }
}
