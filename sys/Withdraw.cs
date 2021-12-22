using System;

namespace ATM
{
    public class Withdraw
    {

        public static int Amount(int mainMenuOption)
        {
            switch (mainMenuOption)
            {
                case 1:
                    int amountToWithdraw = 20;
                    return amountToWithdraw;
                case 2:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("This is not a valid option response");
                    break;
            }
            return -1;
        }
    }
}