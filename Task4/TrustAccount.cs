using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class TrustAccount:SavingAccount 
    {
        public double Fees { get; set; }
        public TrustAccount(string name,double balance,double interestRate):
        base(name, balance, interestRate)
        {
    
        }
    }
}
