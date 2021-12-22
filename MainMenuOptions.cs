using System;

namespace ATM
{
    public class MainMenuOptions
    {

        public static string UserOptions()
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
            string option = Console.ReadLine();
            return option;
        }

        public static string WithdrawOption()
        {
            Console.WriteLine("Please select any amount to withdraw:  ");
            Console.WriteLine();
            Console.WriteLine("     1 ---- $20");
            Console.WriteLine("     2 ---- $40");
            Console.WriteLine("     3 ---- $60");
            Console.WriteLine("     4 ---- $80");
            Console.WriteLine("     5 ---- $100");
            Console.WriteLine("     6 ---- Other");
            Console.WriteLine();
            Console.Write("Option: ");
            string option = Console.ReadLine();
            return option;
        }
    }
}