using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5logic1;
namespace Lab5code
{
    class Program
    {
        static void Main(string[] args)
        {

            ICICI iobj = new ICICI();
            Console.WriteLine("ICICI bank");
            Console.WriteLine("1)Current");
            Console.WriteLine("2)Saving");
            Console.Write("enter the account type : ");
            int i = Convert.ToInt32(Console.ReadLine());

            iobj.AccountType = (BankAccountTypeEnum)i;
            Console.WriteLine(iobj.AccountType);

            iobj.Deposit(50000);
            Console.WriteLine("Deposited 50000 to saving account");

            ICICI iobj2 = new ICICI();
            Console.WriteLine("1)Current");
            Console.WriteLine("2)Saving");
            Console.Write("enter the account type : ");
            int j = Convert.ToInt32(Console.ReadLine());

            iobj2.AccountType = (BankAccountTypeEnum)j;
            iobj2.Deposit(20000);
            Console.WriteLine("Deposited 20000 to Current account");
            iobj.Transfer(iobj2, 5000);
            Console.WriteLine("Transfered 5000 from savings to current account");
            Console.WriteLine("The new Balances are");
            Console.WriteLine($"savings : {iobj.GetBalance()}");
            Console.WriteLine($"Current : {iobj2.GetBalance()}");


            HSBC hobj = new HSBC();
            Console.WriteLine("HSBC Bank");
            Console.WriteLine("1)Current");
            Console.WriteLine("2)Saving");
            Console.Write("enter the account type : ");
            int k = Convert.ToInt32(Console.ReadLine());

            hobj.AccountType = (BankAccountTypeEnum)k;
            Console.WriteLine(hobj.AccountType);

            hobj.Deposit(50000);
            Console.WriteLine("Deposited 50000 to savings account");

            HSBC hobj2 = new HSBC();
            Console.WriteLine("1)Current");
            Console.WriteLine("2)Saving");
            Console.Write("enter the account type : ");
            int l = Convert.ToInt32(Console.ReadLine());

            hobj2.AccountType = (BankAccountTypeEnum)l;
            hobj2.Deposit(20000);
            Console.WriteLine("Deposited 20000 to Current account");

            hobj.Transfer(hobj2, 30000);
            Console.WriteLine("Transfered 30000 from savings to current account");
            Console.WriteLine("The new Balances are");
            Console.WriteLine($"savings : {hobj.GetBalance()}");
            Console.WriteLine($"Current : {hobj2.GetBalance()}");

            Console.Write("the interest for savings account in icici bank is : ");
            iobj.CalculateInterest();
            Console.Write("the interest for current account in icici bank is : ");
            iobj2.CalculateInterest();

            Console.Write("the interest for savings account in HSBC bank is : ");
            hobj.CalculateInterest();
            Console.Write("the interest for current account in HSBC bank is : ");
            hobj2.CalculateInterest();




        }
    }
}
