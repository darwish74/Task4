using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class TrustAccount : SavingAccount
    {
        public TrustAccount()
        {

        }
        public TrustAccount(string name)
        {
         this.Name = name;
        }
        public TrustAccount(string name,int balance)
        {
            this.Name=name;
            this.Balance = balance;
        }
        public int Withdrawablecount { get; set; }
        public DateTime data { get; set; } 
        public TrustAccount(string name,double balance,double interestRate):
        base(name, balance, interestRate)
        {
         
        }
        public new bool Deposit(double amount)
        {
            if (amount >= 5000)
            {
                return base.Deposit(amount + 50);
            }
            else
            {
                return base.Deposit(amount);
            }
        }

        public new bool Withdraw (double amount) 
        {
            if(Withdrawablecount<=3 && amount>=Balance*0.2)
            {
                Withdrawablecount++;
                return base.Withdraw(amount);
            }
            return false;
        }
    }
}
