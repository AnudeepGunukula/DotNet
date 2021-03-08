using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5logic1
{

    public enum BankAccountTypeEnum
    {
        Current = 1,
        Saving = 2
    }
    public interface IBankAccount
    {


        double GetBalance();
        void Deposit(double amount);
        bool Withdraw(double amount);
        bool Transfer(IBankAccount toAccount, double amount);
        BankAccountTypeEnum AccountType { get; set; }

        void CalculateInterest();



    }
}
