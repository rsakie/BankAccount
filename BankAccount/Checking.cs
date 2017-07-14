using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
   
        public static void checking (int accountNumber, double checkingBalance, string accountType)
    {
            Console.WriteLine(accountNumber);
            Console.WriteLine(checkingBalance);
            Console.WriteLine(accountType);
    }
        public Checking()
        {

        }
        ////Methods
        public static void ViewBalance()
        {
            Console.WriteLine();
        }

        public static double Deposit()
        {
            double depositAmount = double.Parse(Console.ReadLine());
            return depositAmount;
        }

        public static double Withdraw()
        {
            double withdrawAmount = double.Parse(Console.ReadLine());

            return withdrawAmount;
        }
    }
    }
