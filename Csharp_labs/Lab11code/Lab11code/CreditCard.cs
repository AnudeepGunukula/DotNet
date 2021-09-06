using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11code
{
    public delegate void payment();
    class CreditCard
    {
        public event payment message;
        private double creditCardNo;
        private string cardHolderName;
        private double balanceAmount;
        private double creditLimit;

        public double CreditCardNo { get => creditCardNo; set => creditCardNo = value; }
        public string CardHolderName { get => cardHolderName; set => cardHolderName = value; }
        public double BalanceAmount { get => balanceAmount; set => balanceAmount = value; }
        public double CreditLimit { get => creditLimit; set => creditLimit = value; }

        public void GetBalance()
        {
            Console.WriteLine(balanceAmount);
        }
        public void GetCreditLimit()
        {

        }
        public void MakePayment(int amount)
        {
            balanceAmount += amount;
            message();
        }
        public void Msg()

        {
            Console.WriteLine("The amount is credited");
        }

    }
}
