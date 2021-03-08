using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
namespace Lab13code
{
    class code3 //kindly make this as startup to get code3 functionality
    {
        static void Main(string[] args) //code 2 is also included in this 
        {
            ArrayList clist = new ArrayList();
            Contact cobj;
            while (true)
            {
                Console.WriteLine("1)Add contact in list");
                Console.WriteLine("2)serialize the list in Soap format");
                Console.WriteLine("3)Deserialize the list from Soap format");
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
                        FileStream fs = new FileStream("contact.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        SoapFormatter sf = new SoapFormatter();
                        sf.Serialize(fs, clist);
                        Console.WriteLine("Succesfully serialized");
                        fs.Close();


                        break;
                    case 3:
                        FileStream fd = new FileStream("contact.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        SoapFormatter sd = new SoapFormatter();
                        ArrayList cclist = (ArrayList)sd.Deserialize(fd);
                        Console.WriteLine("Successfully deserialized ");
                        foreach (var obj in cclist)
                        {
                            Contact xobj = (Contact)obj;
                            Console.WriteLine($"The contact number is {xobj.ContactNo}");
                            Console.WriteLine($"The Contact name is {xobj.ContactName}");
                            Console.WriteLine($"The cell number is {xobj.CellNo}");
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
