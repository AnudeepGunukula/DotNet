using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13code4
{
    [Serializable]
    public class Supplier
    {
        private int supplierID;
        private string supplierName;
        private string city;
        private string phoneNo;
        private string email;

        public int SupplierID { get => supplierID; set => supplierID = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string City { get => city; set => city = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Email { get => email; set => email = value; }

        public static void AcceptDetails(Supplier s1)
        {
            Console.Write("Enter the supplier id : ");
            s1.SupplierID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the supplier Name: ");
            s1.SupplierName = Console.ReadLine();
            Console.Write("Enter the City: ");
            s1.City = Console.ReadLine();
            Console.Write("Enter the supplier PhoneNo: ");
            s1.PhoneNo = Console.ReadLine();
            Console.Write("Enter the supplier email : ");
            s1.Email = Console.ReadLine();
        }
        public Supplier DisplayDetails()
        {
            Supplier s = new Supplier();
            s.SupplierID = supplierID;
            s.SupplierName = supplierName;
            s.City = city;
            s.PhoneNo = phoneNo;
            s.Email = email;
            Console.WriteLine($"Supplier id is   : {s.SupplierID}");
            Console.WriteLine($"Supplier name is : {s.SupplierName}");
            Console.WriteLine($"Supplier city is : {s.City}");
            Console.WriteLine($"Supplier phone is: {s.PhoneNo}");
            Console.WriteLine($"Supplier email is: {s.Email}");
            return s;
        }
    }
}
