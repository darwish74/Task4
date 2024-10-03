using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class SavingAccount:Account
    {
        public SavingAccount(double interestRate):base(string name, double balance)
        {
            InterestRate = interestRate;
        }

        public double InterestRate { get; set; }
    }
}
