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

            Client bill = new Client("Bill Johnson", "3118 Billy Bridge Ln", "216-376-9806");

            Savings savings = new Savings(1482306325, 5000.00, "Savings Account");

            Checking checking = new Checking (1482306324, 150000.00, "Checking Account");
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
            Console.WriteLine(" Welcome to Low Point Bank\n");
            Console.WriteLine("Please select a menu option below\n");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Cash");
            Console.WriteLine("3. Withdraw Cash");
            Console.WriteLine("4. View Account Information");
            Console.WriteLine("5. Exit\n");
            


            int selection;
            selection = int.Parse(Console.ReadLine());

            //Must instantiate one client object

            // Must instantiate one checking account object
            //Must instantiate one savings account object
            // All menu options listed above must have functionality behind them
            // Program should run until user selects 'Exit'
            if (selection == 1)
            {
                string balance;
                Console.WriteLine("Which Account Balance do you want to view? \n");
                Console.WriteLine("1-1. Checking Account Balance");
                Console.WriteLine("1-2. Savings Account Balance");
                Console.WriteLine("Please enter your selection: ");
                balance = Console.ReadLine();
                if (balance == "1")
                {
                    Checking checkingBalance = new Checking(1482306324, 150000.00, "Checking");
                    Console.WriteLine("Your Checking Account Balance is" + checkingBalance);
                    
                    //lost on how to retrieve balances
                }
                if (balance == "2")
                {
                    Savings savingsBalance = new Savings(1482306325, 5000.00, "Savings");
                    Console.WriteLine("Your Savings Account Balance is " + savingsBalance);
                    
                   
                }
                else if (selection == 2)
                {
                    string deposit;
                    Console.WriteLine("Which Account do you want to deposit cash? \n");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    Console.WriteLine("Please enter selection: ");
                    deposit = Console.ReadLine();
                    if (deposit == "1")
                    {
                        Console.WriteLine("Enter your deposit amount: \t$");
                        double checkingDeposit = int.Parse(Console.ReadLine());
                        checking.Deposit();
                    }
                    if (deposit == "2")
                    {
                        Console.WriteLine("Enter your deposit amount: \t$");
                        double savingsDeposit = int.Parse(Console.ReadLine());
                        savings.Deposit();
                    }

                    else if (selection == 3)
                    { 
                        string withdraw;
                        Console.WriteLine("Which Account do you want to withdraw from? \n");
                        Console.WriteLine("1. Checking");
                        Console.WriteLine("2. Savings");
                        Console.WriteLine("Please enter selection: ");
                        withdraw = Console.ReadLine();
                        if (withdraw == "1")
                        {
                            Console.WriteLine("Enter your withdraw amount: ");
                            double checkingWithdraw = int.Parse(Console.ReadLine());
                            
                        }
                        if (withdraw == "2")
                        {
                            Console.WriteLine("Enter withdraw amount: ");
                            double savingsWithdraw = int.Parse(Console.ReadLine());

                        }
                         else if (selection == 4)
                        {
                            Console.WriteLine("Client Information" + bill);
                        }
                        else if (selection == 5)
                        {
                           return;
                        }
                                                    


                    }



                }

            }
        }
    }
}
