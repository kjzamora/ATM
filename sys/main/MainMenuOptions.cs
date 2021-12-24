using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class MainMenuOptions : IMainMenuOptions
    {
        ISystemMessaging _systemMessaging;

        public MainMenuOptions(ISystemMessaging systemMessaging)
        {
            _systemMessaging = systemMessaging;
        }
        public void Selection(int selection)
        {
            switch (selection)
            {
                case 1: // Withdraw Cash
                    WithdrawMenu.Control();
                    break;
                case 2: // Cash Transfer
                    break;
                case 3: // Desposit Cash
                    break;
                case 4: // Display Balanace
                    break;
                case 5: // Exit
                    _systemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
