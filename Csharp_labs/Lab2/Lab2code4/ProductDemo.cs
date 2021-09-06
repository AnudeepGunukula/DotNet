using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2code4
{
    class ProductDemo
    {
        public int ProductId;
        public string ProductName;
        public float Price;
        public int Quantity;
        public double amountPayable;
        public ProductDemo()
        {
            Console.Write("Enter the id of product : ");
            ProductId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of product : ");
            ProductName = Console.ReadLine();
            Console.Write("Enter Price : ");
            Price = float.Parse(Console.ReadLine());
            Console.Write("Enter the Qunatity : ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            amountPayable = Price * Quantity;
            //Conveting to Reference types (BOXING)
            object objId = ProductId;
            object objName = ProductName;
            object objPrice = Price;
            object objQuant = Quantity;
            Console.WriteLine();
            Console.WriteLine("Product Details : ");
            //displaying values by unboxing
            Console.WriteLine($"ProductId : {(int)objId}");
            Console.WriteLine($"ProductName : {(string)objName}");
            Console.WriteLine($"Price : {(float)objPrice}");
            Console.WriteLine($"Qunatity : {(int)objQuant}");
            Console.WriteLine($"the amount Payable is Rs.{amountPayable}");

        }



        static void Main(string[] args)
        {
            ProductDemo pd = new ProductDemo();
        }
    }
}
