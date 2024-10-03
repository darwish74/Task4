using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Account
    {
        public Account() { }
        public Account(string name, object name1, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; set; }
        public double Balance { get; set; }

        public bool Deposit(double value)
        {
            if (value < 0)
            {
                return false;
            }
            else
            {
                Balance += value;
                return true;    
            }
        }
        public bool Withdraw(double value)
        {
            if (Balance-value>=0)
            {
                Balance -= value;   
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Account operator+(Account left, Account right)
        {
            Account account = new Account() {Balance=left.Balance+right.Balance };
            return account;
        }
    }
}
