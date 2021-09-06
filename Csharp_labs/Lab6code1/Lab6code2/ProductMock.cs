using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6code2
{
    class ProductMock
    {
        private int productId;
        private string productName;
        private double price;

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }

        public ProductMock()
        {

        }
        public ProductMock(int id, string name, double price)
        {

        }
    }
}
