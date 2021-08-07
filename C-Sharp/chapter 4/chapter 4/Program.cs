using System;

namespace chapter_4
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            Console.WriteLine($"Initial name is: {myAccount.GetName()}");

            Console.WriteLine("Enter the new name: ");

            string theName = Console.ReadLine();

            myAccount.SetName(theName);

            Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
        }
    }

    class Account
    {
        private string name;

        public void SetName(string accountName)
        {
            name = accountName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
