using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5logic1
{
    public class ICICI : BankAccount
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
            if (balance - amount >= 5000)
            {

                balance -= amount;
                ICICI iobj2 = (ICICI)toAccount;
                iobj2.balance += amount;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void CalculateInterest()
        {
            Console.WriteLine((balance * 7) / 100);
        }
    }
}
