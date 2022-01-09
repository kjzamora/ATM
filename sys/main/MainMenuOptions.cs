using System;

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
                    Console.Clear();
                    int withdrawOptionAmount = _withdrawMenu.Control();
                    return (withdrawOptionAmount, optionChoice);
                case 2: // Desposit Cash
                    optionChoice = 2;
                    Console.Clear();
                    int depositOptionAmount = _depositMenu.Control();
                    return (depositOptionAmount, optionChoice);
                case 3: // Display Balanace
                    optionChoice = 3;
                    Console.Clear();
                    return (0, optionChoice); // likely a better way... could add special handling to mainmenu, but that breaks single-responsibility principle...
                case 4: // Exit
                    Console.Clear();
                    _systemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                    break;
            }
            return (0, 0);
        }
    }
}
