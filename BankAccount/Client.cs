using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //fields
        protected string clientName = "Bill Johnson";
        protected string clientAddress = "12340 Fifth Street";
        protected string phoneNumber = " 216-239-8976";


        //properties
        public string ClientName { get; }
        public string ClientAddress { get; }
        public string PhoneNumber { get; }

        //constructor
        public Client()
        {

        }
        public Client(string clientName, string clientAddress, string phoneNumber)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.phoneNumber = phoneNumber;
        }
         //method client info
         public static void Info()
            {
            
        }
    }

    
}
