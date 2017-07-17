using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {
        public Savings(int accountNumber, double balance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
            
        }
        public override double Withdraw()
        {
            if (balance < 0.00)
            {
                Console.WriteLine("Insufficient funds.");
                return 0.00d;
            }
            else
            {
                double withdrawAmmount = double.Parse(Console.ReadLine());
                balance -= withdrawAmmount;
                return withdrawAmmount;
            }
        }
        //Note: Savings Account must include a minimum balance.User cannot withdraw money if balance will drop below minimum.
        //1 property
        //1 constructor
        //cannot withdraw past min. bal  !=0
    }
}
