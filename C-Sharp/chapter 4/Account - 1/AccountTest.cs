using System;

namespace chapter_4
{
    class AccountTest2
    {
        static void main()
        {
            Account2 account1 = new Account2("Donkey Kong");
            Account2 account2 = new Account2("Luigi Mario");

            Console.WriteLine($"Account 1's name is: {account1.Name}");
            Console.WriteLine($"Account 2's name is: {account2.Name}");



           // Console.WriteLine($"Initial name is: {myAccount.GetName()}");
            //string theName = Console.ReadLine();

//            myAccount.Name = theName;

  //          Console.WriteLine($"myAccount's name is: {myAccount.Name}");
        }    
    }
}