﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {

        public Checking(int accountNumber, double checkingBalance, string accountType)
        {
            Console.WriteLine(accountNumber);
            Console.WriteLine(checkingBalance);
            Console.WriteLine(accountType);
        }
        
        ////Methods
        //public static void
        //{
        //    Console.WriteLine();
        //}

        //public static double Deposit()
        //{
        //    double depositAmount = double.Parse(Console.ReadLine());
        //    return depositAmount;
        //}

        //public static double Withdraw()
        //{
        //    double withdrawAmount = double.Parse(Console.ReadLine());

        //    return withdrawAmount;
        //}
    }
   }

