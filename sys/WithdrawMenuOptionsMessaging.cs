using System;

namespace ATM
{
    public class WithdrawMenuOptionsMessaging
    {
        public static void WithdrawOptions()
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
        }
    }
}