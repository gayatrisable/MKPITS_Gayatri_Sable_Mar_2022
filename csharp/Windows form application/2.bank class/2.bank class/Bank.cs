using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.bank_class
{
    class bank
    {
        public int accountno;
        public int balance = 1000;
        public string deposit(int amount)
        {
            balance = balance + amount;
            return "amount deposited successfully, bal is " + balance.ToString();

        }
        public string withdrawl(int amount)
        {
            string res = null;
            if (amount > balance)
            {
                res = "insufficient fund , cannot withdraw money";
            }
            else
            {
                balance = balance - amount;
                res = "amount withdrawl successfully, bal is " + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balance amount is " + balance.ToString();
        }

    }
}
