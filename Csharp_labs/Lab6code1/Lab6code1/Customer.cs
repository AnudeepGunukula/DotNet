using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6code1
{
    class Customer
    {
        private int CustomerId;
        private string CustomerName;
        private string Address;
        private string City;
        private string Phone;
        private double CreditLimit;

        public int CustomerId1 { get => CustomerId; set => CustomerId = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string City1 { get => City; set => City = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public double CreditLimit1 { get => CreditLimit; set => CreditLimit = value; }

        public Customer()
        {

        }
        public Customer(int id, string name, string add, string city, string phone, double limit)
        {
            this.CustomerId = id;
            this.CustomerName = name;
            this.Address = add;
            this.City = city;
            this.Phone = phone;
            this.CreditLimit = limit;


        }
    }
}
