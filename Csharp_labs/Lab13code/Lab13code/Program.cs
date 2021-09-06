using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab13code
{
    class Program //kindly make this as startup to get code 1 and code 2 functionality
    {
        static void Main(string[] args) //code 2 is also included in this 
        {
            List<Contact> clist = new List<Contact>();
            Contact cobj;
            while (true)
            {
                Console.WriteLine("1)Add contact in list");
                Console.WriteLine("2)serialize the list in binary format");
                Console.WriteLine("3)Deserialize the list from binary format");
                Console.WriteLine("4)Quit");
                Console.Write("Enter your option:");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 1 || x > 3)
                {
                    break;
                }
                switch (x)
                {
                    case 1:
                        cobj = new Contact();
                        Console.Write("Enter the Contact Number:");
                        cobj.ContactNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Contact Name:");
                        cobj.ContactName = Console.ReadLine();
                        Console.Write("Enter the Cell Number:");
                        cobj.CellNo = Console.ReadLine();
                        clist.Add(cobj);
                        Console.WriteLine("Succesfully added record to list");
                        break;
                    case 2:
                        FileStream fs = new FileStream("contact.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        BinaryFormatter bi = new BinaryFormatter();
                        bi.Serialize(fs, clist);
                        Console.WriteLine("Succesfully serialized");
                        fs.Close();


                        break;
                    case 3:
                        FileStream fd = new FileStream("contact.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        BinaryFormatter bd = new BinaryFormatter();
                        List<Contact> cclist = (List<Contact>)bd.Deserialize(fd);
                        Console.WriteLine("Successfully deserialized ");
                        foreach (var obj in cclist)
                        {

                            Console.WriteLine($"The contact number is {obj.ContactNo}");
                            Console.WriteLine($"The Contact name is {obj.ContactName}");
                            Console.WriteLine($"The cell number is {obj.CellNo}");
                            Console.WriteLine("======================================");
                        }


                        break;
                    default:
                        break;

                }

            }

        }
    }
}
