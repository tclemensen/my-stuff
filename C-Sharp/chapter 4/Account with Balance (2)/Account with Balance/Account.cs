using System;
using System.Collections.Generic;
using System.Text;

namespace Account_with_Balance_Deposit_and_Withdrawal
{
    class Account
    {
        public string Name { get; set; }

        private decimal balance; // instance variable


        public Account(string accountName, decimal initialBalance) // Account constructor that receives two parameters
        {
            Name = accountName;
            balance = initialBalance;
        }

        public decimal Balance // Balance property with validation
        {
            get
            {
                return balance;
            }
            private set // Only used within the class
            {
                //checks to see if the balance > 0.0. If not, it will keep it's previous value
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount) // Method that adds a valid amount to balance
        {
            if (depositAmount > 0.0m) // Check to verify that the deposit amount is valid
            {
                Balance = Balance + depositAmount; // then add it to the balance
            }
        }

        public void Withdraw(decimal withdrawalAmount)
        {
            if (withdrawalAmount > 0.0m)
            {
                Balance = Balance - withdrawalAmount;
            }            
        }
    }
}
