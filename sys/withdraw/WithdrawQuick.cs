using System;

namespace ATM
{
    public class WithdrawQuick
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
                //case 6:
                //    amountToWithdraw = RetrieveUserCustomWithdrawInput.Input(); // Should I call this here? Or is there a way to "return" to a screen instead... Feels like this breaks single responsibility principle
                //    break;
            }
            return amountToWithdraw;
        }
    }
}