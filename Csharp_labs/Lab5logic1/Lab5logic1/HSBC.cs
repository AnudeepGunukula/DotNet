using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5logic1
{
    public class HSBC : BankAccount
    {
        public override bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance = balance - amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Transfer(IBankAccount toAccount, double amount)
        {
            if (balance - amount >= 1000)
            {
                balance -= amount;
                HSBC hobj2 = (HSBC)toAccount;
                hobj2.balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CalculateInterest()
        {
            Console.WriteLine((balance * 5) / 100);
        }

    }
}
