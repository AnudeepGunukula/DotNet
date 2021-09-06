using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab8code
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myhash = new Hashtable();
            while (true)
            {
                Console.WriteLine("1)Add Record in Hashtable");
                Console.WriteLine("2)Search Record in Hashtable");
                Console.WriteLine("3)Display all Records");
                Console.WriteLine("4)Total Count of Records");
                Console.WriteLine("5)Remove any particular Record");
                Console.WriteLine("6)Quit");
                Console.Write("Enter the option:");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 1 || i > 5)
                {
                    break;
                }
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter the RTO Key");
                        string k = Console.ReadLine();
                        Console.WriteLine("Enter the RTO  Place");
                        string p = Console.ReadLine();
                        myhash.Add(k, p);
                        Console.WriteLine("successfully added record");
                        break;
                    case 2:
                        Console.WriteLine("Enter the RTO key to search");
                        string str = Console.ReadLine();
                        int flag = 0;
                        foreach (string key in myhash.Keys)
                        {
                            if (str == key)
                            {
                                Console.WriteLine("Record Found");
                                Console.WriteLine($"The RTO Key is {key} and RTO Place is {myhash[key]}");
                                flag = 1;
                            }

                        }
                        if (flag == 0)
                        {
                            Console.WriteLine("Record not found");
                        }
                        break;
                    case 3:
                        foreach (string key in myhash.Keys)
                        {

                            Console.WriteLine($"The RTO Key is {key} and RTO Place is {myhash[key]}");
                        }
                        break;
                    case 4:
                        Console.WriteLine($"The Total Count of Records is {myhash.Count}");
                        break;
                    case 5:
                        Console.WriteLine("Enter the key name to delete record:");
                        string ke = Console.ReadLine();
                        try
                        {
                            myhash.Remove(ke);
                            Console.WriteLine("successfully  deleted");

                        }
                        catch
                        {
                            throw new KeyNotFoundException();

                        }
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
