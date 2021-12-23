using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class WithdrawMenu
    {
        public static void Control ()
        {
            WithdrawMenuOptionsMessaging.WithdrawOptions();
            int withdrawMenuOption = RetrieveWithdrawOption.Input();
            int withdrawOptionAmount;
            if (withdrawMenuOption < 6)
            {
                withdrawOptionAmount = WithdrawQuick.Amount(withdrawMenuOption);
            }
            else
            {
                withdrawOptionAmount = RetrieveUserCustomWithdrawInput.Input();
            } 
        }
    }
}
