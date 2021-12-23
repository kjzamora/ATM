using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class MainMenu
    {
        public static void Selection(int selection)
        {
            switch (selection)
            {
                case 1: // Withdraw Cash
                    WithdrawMenuOptionsMessaging.WithdrawOptions();
                    break;
                case 2: // Cash Transfer
                    break;
                case 3: // Desposit Cash
                    break;
                case 4: // Display Balanace
                    break;
                case 5: // Exit
                    SystemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
