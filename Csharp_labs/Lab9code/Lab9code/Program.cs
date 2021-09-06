using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9code
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mydict = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("1)Add Record");
                Console.WriteLine("2)Change Record using Indexer");
                Console.WriteLine("3)Adding new key using Indexer");
                Console.WriteLine("4)print record using key");
                Console.WriteLine("5)Print all records");
                Console.WriteLine("6)Remove a record");
                Console.WriteLine("Enter your option:");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 1 || i > 7)
                {
                    break;
                }
                switch (i)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("keys cant be duplicate but values can");
                            Console.Write("(key)Enter the file extension:");
                            string k = Console.ReadLine();
                            Console.Write("(value)Enter the file type:");
                            string v = Console.ReadLine();
                            mydict.Add(k, v);
                        }

                        catch (ArgumentException)
                        {
                            Console.WriteLine($"Exception occured key already exist");
                        }


                        break;
                    case 2:
                        try
                        {
                            Console.Write("Enter the Record key to change:");
                            string kee = Console.ReadLine();

                            if (mydict.ContainsKey(kee))
                            {
                                Console.Write("Enter the new file type:");
                                string val = Console.ReadLine();
                                mydict[kee] = val;
                                Console.WriteLine($"the record is modified as file extension {kee} and file type {val}");
                            }
                            else
                            {
                                throw new KeyNotFoundException();
                            }

                        }
                        catch (KeyNotFoundException)
                        {
                            Console.WriteLine("exception occured key is not found in records");
                        }

                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Using indexer only add new keys otherwise the old one modifies");
                            Console.Write("Enter the new file Extension to add:");
                            string kex = Console.ReadLine();
                            Console.Write("Enter the new file type to add:");
                            string vax = Console.ReadLine();
                            mydict[kex] = vax;
                            Console.WriteLine("Succesfully added new record using indexer");
                        }

                        catch (ArgumentException)
                        {
                            Console.WriteLine($"Exception occured key already exist");
                        }

                        break;
                    case 4:
                        try
                        {

                            Console.Write("Enter the key to print the record:");
                            string kez = Console.ReadLine();
                            Console.WriteLine($"the file extension is {kez} and file type is {mydict[kez]}");
                        }
                        catch (KeyNotFoundException)
                        {
                            Console.WriteLine("Exception occured key not found ");
                        }
                        break;
                    case 5:
                        foreach (string st in mydict.Keys)
                        {
                            Console.WriteLine($"The file extension is {st} and filetype is {mydict[st]}");
                        }
                        break;
                    case 6:
                        try
                        {
                            Console.Write("Enter the key to remove that record: ");
                            string kell = Console.ReadLine();
                            mydict.Remove(kell);
                        }
                        catch (KeyNotFoundException)
                        {
                            Console.WriteLine("Exception occured key not found ");
                        }

                        break;
                    default:
                        break;
                }

            }
        }
    }
}
