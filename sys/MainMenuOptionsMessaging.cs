using System;

namespace ATM
{
    public class MainMenuOptionsMessaging
    {

        public static void UserOptions()
        {
            Console.WriteLine("Please select one of the following options:  ");
            Console.WriteLine();
            Console.WriteLine("     1 ---- Withdraw Cash");
            Console.WriteLine("     2 ---- Cash Transfer");
            Console.WriteLine("     3 ---- Deposit Cash");
            Console.WriteLine("     4 ---- Display Balance");
            Console.WriteLine("     5 ---- Exit");
            Console.WriteLine();
            Console.Write("Option: ");
        }
    }
}