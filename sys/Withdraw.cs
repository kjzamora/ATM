using System;

namespace ATM
{
    public class Withdraw
    {

        public static int Amount(int mainMenuOption)
        {
            int amountToWithdraw = 0;
            switch (mainMenuOption)
            {
                
                case 1:
                    amountToWithdraw = 20;
                    break;
                case 2:
                    amountToWithdraw = 40;
                    break;
                case 3:
                    amountToWithdraw = 60;
                    break;
                case 4:
                    amountToWithdraw = 80;
                    break;
                case 5:
                    amountToWithdraw = 100;
                    break;
                case 6:
                    amountToWithdraw = RetrieveUserCustomWithdrawInput.Input();
                    break;
            }
            return amountToWithdraw;
        }
    }
}