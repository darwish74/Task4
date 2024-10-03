using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class CheckingAccount:Account
    {
        public double Fee { get; set; }
        public CheckingAccount(string name, double balance)
        :base(name, balance)
        {
            Fee = 1.5;
        }
        public new bool Withdraw(double value)
        { 
         return base.Withdraw(value+Fee);
        }
    }
}
