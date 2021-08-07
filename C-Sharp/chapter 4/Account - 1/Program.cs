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
}