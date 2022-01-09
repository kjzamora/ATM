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
        IWithdrawMenu _withdrawMenu;
        IDepositMenu _depositMenu;

        public MainMenuOptions(ISystemMessaging systemMessaging, IWithdrawMenu withdrawMenu, IDepositMenu depositMenu)
        {
            _systemMessaging = systemMessaging;
            _withdrawMenu = withdrawMenu;
            _depositMenu = depositMenu;
        }

        public (int optionAmount, int optionChoice) Selection(int selection)
        {
            int optionChoice;
            switch (selection)
            {
                case 1: // Withdraw Cash
                    optionChoice = 1;
                    int withdrawOptionAmount =_withdrawMenu.Control();
                    return (withdrawOptionAmount, optionChoice);
                case 2: // Cash Transfer
                    break;
                case 3: // Desposit Cash
                    optionChoice = 3;
                    int depositOptionAmount = _depositMenu.Control();
                    return (depositOptionAmount, optionChoice);
                case 4: // Display Balanace
                    //optionChoice = 4;
                    break;
                case 5: // Exit
                    _systemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                    break;
            }
            return (0, 0);
        }
    }
}
