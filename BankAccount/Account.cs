using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        //fields
        protected int accountNumber;
        protected double balance;
        protected string accountType;

        //properties
        public int AccountNumber { get; }
        public double Balance { get; }
        public string AccountType { get; }

        public Account()
        {

        }

        //not sure of what im doing exactly
        public Account(int accountNumber, double balance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }

        public virtual string viewBalance(double balance)
        {
            return "Account Balance: " + balance;
        }


        public virtual double Withdraw()
        {
            double withdrawAmmount = double.Parse(Console.ReadLine());
            balance -= withdrawAmmount;
            return withdrawAmmount;

        }
        public virtual double Deposit()
        {
            double depositAmmount = double.Parse(Console.ReadLine());
            balance += depositAmmount;
            return depositAmmount;

        }
    }
}
