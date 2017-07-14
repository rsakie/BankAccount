using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Low Point Bank\n");
            Console.WriteLine("Please select a menu option below\n");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Cash");
            Console.WriteLine("3. Withdraw Cash");
            Console.WriteLine("4. Exit\n");
            //int choice = int.Parse(Console.ReadLine());


            Client clientName = new Client();
            
            //Must instantiate one client object

            // Must instantiate one checking account object
            //Must instantiate one savings account object
            // All menu options listed above must have functionality behind them
            // Program should run until user selects 'Exit'


            //View Client Information
            //View Account Balance
            //Checking Account Balance
            //Savings Account Balance
            //Deposit Funds
            //To Checking Account
            //To Savings Account
            //Withdraw Funds
            //From Checking Account
            //From Savings Account
            //Exit
        }
    }
}
