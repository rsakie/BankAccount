using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //fields
        protected int accountNumber = 1482306324;
        protected double checkingBalance = 150000.00d;
        protected double savingsBalance = 5000.00d;

        //properties
        public int AccountNumber { get; }
        public double CheckingBalance { get; }
        public double SavingsBalance { get; }

        public Account()
        {

        }
        public Account(int accountNumber, double checkingBalance, double savingsBalance)
        {
            this.AccountNumber = AccountNumber;
            this.CheckingBalance = CheckingBalance;
            this.SavingsBalance = SavingsBalance;
        }
    

    }
}
