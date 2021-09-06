using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11code
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard cc = new CreditCard();
            cc.CreditCardNo = 963852741963;
            cc.CardHolderName = "Ashwin";
            cc.BalanceAmount = 10000;
            cc.CreditLimit = 50000;

            cc.message += new payment(cc.Msg);
            cc.MakePayment(1000);
            //cc.GetBalance();
        }
    }
}
