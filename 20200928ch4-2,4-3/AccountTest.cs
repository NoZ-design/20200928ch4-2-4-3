using System;

namespace _20200928ch4_2_4_3
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            Console.WriteLine($"Initial name is:{myAccount.GetName()}");

            Console.Write($"Enter the name:");
            string theName = Console.ReadLine();
            myAccount.SetName(theName);

            Console.WriteLine($"myAccount's name is:{myAccount.GetName()}");
        }
    }
}
