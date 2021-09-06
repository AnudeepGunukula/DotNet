using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7code2
{
    class Product : IComparable<Product>
    {
        private int productNo;
        private string productName;
        private double rate;
        private double stock;

        public Product()
        {

        }


        public int ProductNo { get => productNo; set => productNo = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Rate { get => rate; set => rate = value; }
        public double Stock { get => stock; set => stock = value; }

        public int CompareTo(Product x)
        {
            return productNo.CompareTo(x.productNo);
        }
    }
}
