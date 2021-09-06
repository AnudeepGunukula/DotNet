using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6code1
{


    class InvalidCreditLimit : Exception
    {
        public InvalidCreditLimit(string str) : base(str)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer cs = new Customer();
            Console.Write("Enter the Customer id: ");
            cs.CustomerId1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Customer name: ");
            cs.CustomerName1 = Console.ReadLine();
            Console.Write("Enter the Customer Address ");
            cs.Address1 = Console.ReadLine();
            Console.Write("Enter the Customer City ");
            cs.City1 = Console.ReadLine();
            Console.Write("Enter the Customer Phone: ");
            cs.Phone1 = Console.ReadLine();
            Console.Write("Enter the Customer CreditLimit: ");

            int i = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (i <= 50000)
                {
                    cs.CreditLimit1 = i;

                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw new InvalidCreditLimit("your credit limit reached ");
            }
            finally
            {
                Console.WriteLine("try after some time");
            }







        }
    }
}
