using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6code2
{
    class ProductTest
    {
        private static void DisplayDetails(ProductMock pm)
        {
            Console.WriteLine("product Details are ");
            Console.WriteLine($"Product id: {pm.ProductId}");
            Console.WriteLine($"Product name: {pm.ProductName}");
            Console.WriteLine($"Product price: {pm.Price}");

        }
        private static void GetProductDetails()
        {
            ProductMock pm = new ProductMock();
            Console.WriteLine("Enter the productid:");
            try
            {

                int id = Convert.ToInt32(Console.ReadLine());
                if (id > 0)
                {
                    pm.ProductId = id;
                }
                else throw new Exception();
            }
            catch
            {
                throw new DataEntryException("Product ID must be greater than zero");
            }

            Console.WriteLine("Enter the product name:");
            string st = Console.ReadLine();
            if (st == "")
            {
                throw new DataEntryException("Product Name cannot be left blank");
            }

            foreach (int i in st)
            {
                if (!((i >= 48 && i <= 57) || (i >= 65 && i <= 90) || (i >= 97 && i <= 122)))
                {
                    throw new DataEntryException("Product Name should have alphabets and numbers only");
                }
            }
            pm.ProductName = st;
            Console.WriteLine("Enter the Product Price:");
            double p = Convert.ToDouble(Console.ReadLine());
            if (p <= 0)
            {
                throw new DataEntryException("Price of product must be greater than zero.");
            }

            DisplayDetails(pm);
        }
        public static void Main(string[] args)
        {
            GetProductDetails();




        }

    }
}
