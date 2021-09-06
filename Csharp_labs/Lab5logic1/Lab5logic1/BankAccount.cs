using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5logic1
{
    public abstract class BankAccount : IBankAccount
    {
        protected double balance;


        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        public double GetBalance()
        {
            return balance;
        }
        public abstract bool Withdraw(double amount);
        public abstract bool Transfer(IBankAccount toAccount, double amount);

        public BankAccountTypeEnum AccountType { get; set; }

        public void CalculateInterest()
        {

        }


    }
}
