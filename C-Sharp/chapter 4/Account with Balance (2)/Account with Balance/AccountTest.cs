using System;


namespace Account_with_Balance_Deposit_and_Withdrawal
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Tom Bombadil", 50.00m);   // Setting initial values
            Account account2 = new Account("Frodo Baggins", -7.53m);

            DisplayAccount(account1);
            DisplayAccount(account2);
            // Console.WriteLine($"{account1.Name}'s balance is: {account1.Balance:C}"); // Displaying inital values
            // Console.WriteLine($"{account2.Name}'s balance is: {account2.Balance:C}");

            Console.WriteLine("\nEnter deposit amount for account1: "); // Asks for input for how much to deposit on account1's balance
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Adding {depositAmount:C} to account1's balance.\n");

            account1.Deposit(depositAmount); // calls to deposit in account1's balance

            // display current balances

            DisplayAccount(account1);
            DisplayAccount(account2);
            //Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            //Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            // prompt for, then read input

            Console.Write("\nEnter deposit amount for account2: "); // asks for deposit on account2's balance
            depositAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {depositAmount:C} to account2's balance\n");

            account2.Deposit(depositAmount); // deposits the funds on account2's balance

            // displays current balances

            Console.WriteLine($"{account1.Name}'s balance is: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance is: {account2.Balance:C}");

            Console.Write("\nEnter withdrawal amount for account1: ");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

            account1.Withdraw(withdrawalAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            Console.Write("\nEnter withdrawal amount for account2: ");
            withdrawalAmount = decimal.Parse(Console.ReadLine());

            account2.Withdraw(withdrawalAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        }

        static void DisplayAccount(Account accountToDisplay)
        {
            Console.WriteLine($"{accountToDisplay.Name}'s balance: {accountToDisplay.Balance}");
        }
    }
}
