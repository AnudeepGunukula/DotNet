using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7code
{
    class Program
    {

        public static void AddContact(Contact c, List<Contact> li)
        {

            Console.Write("Enter the contact Number :");
            c.ContactNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Contact name :");
            c.ContactName = Console.ReadLine();
            Console.Write("Enter the Cell Number :");
            c.CellNo = Console.ReadLine();
            li.Add(c);
        }
        public static void DisplayContact(List<Contact> li)
        {
            Console.Write("Enter the Contact no u want to display :");
            int x = Convert.ToInt32(Console.ReadLine());
            foreach (var y in li)
            {
                if (y.ContactNo == x)
                {
                    Console.WriteLine($"Contact number is {y.ContactNo}");
                    Console.WriteLine($"Contact Name is {y.ContactName}");
                    Console.WriteLine($"Cell number is {y.CellNo}");
                }
            }
        }
        public static void EditContact(List<Contact> li)
        {
            Console.Write("Enter the Contact no u want to edit :");
            int z = Convert.ToInt32(Console.ReadLine());
            foreach (var y in li)
            {
                if (y.ContactNo == z)
                {
                    Console.Write("Enter the new Contact number :");
                    y.ContactNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the new Contact name :");
                    y.ContactName = Console.ReadLine();
                    Console.Write("Enter the new Cell number:");
                    y.CellNo = Console.ReadLine();
                }
            }
        }
        public static void ShowAllContacts(List<Contact> li)
        {
            foreach (var y in li)
            {
                Console.WriteLine($"Contact number is {y.ContactNo}");
                Console.WriteLine($"Contact Name is {y.ContactName}");
                Console.WriteLine($"Cell number is {y.CellNo}");
                Console.WriteLine("==================================");

            }
        }
        static void Main(string[] args)
        {
            List<Contact> li = new List<Contact>();
            Contact c;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1)Add Contact");
                Console.WriteLine("2)Display Contact");
                Console.WriteLine("3)Edit Contact");
                Console.WriteLine("4)Show All Contacts");
                Console.WriteLine("5)Quit");
                Console.Write("Enter the option :");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 1 || i > 4)
                {
                    break;
                }
                switch (i)
                {
                    case 1:
                        c = new Contact();

                        AddContact(c, li);
                        break;
                    case 2:
                        DisplayContact(li);
                        break;
                    case 3:
                        EditContact(li);
                        break;
                    case 4:
                        ShowAllContacts(li);
                        break;
                    default:
                        break;


                }



            }
        }
    }
}
