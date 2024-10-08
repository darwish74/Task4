﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class SavingAccount:Account
    {   public SavingAccount() { }  
        public SavingAccount(string name) { this.Name = name; }
        public SavingAccount(string name,double balance) { this.Name = name; this.Balance = balance; }
        public SavingAccount(string name, double balance ,double interestRate):
        base(name,balance)
        {
            InterestRate = interestRate;
        }

        public double InterestRate { get; set; }

        public new bool Withdraw(double value)
        {
            return base.Withdraw(value + InterestRate);   
        }
    }
}
