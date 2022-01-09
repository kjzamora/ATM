using System.Globalization;

namespace ATM
{
    public class Application : IApplication
    {
        ISystemMessaging _systemMessaging;
        ICheckUser _checkUser;
        IRetrieveUserInput _retrieveUserInput;
        ICheckPin _checkPin;
        IRetrieveUserInfo _retrieveUserInfo;
        IMainMenu _mainMenu;
        IBalanceUpdate _balanceUpdate;
        IUpdateUserInfo _updateUserInfo;
        IQuitApplicationHandle _quitApplicationHandle;
        IUpdate _update;

        public Application(
            ISystemMessaging systemMessaging,
            ICheckUser checkUser,
            IRetrieveUserInput retrieveUserInput,
            ICheckPin checkPin,
            IRetrieveUserInfo retrieveUserInfo,
            IMainMenu mainMenu,
            IBalanceUpdate balanceUpdate,
            IUpdateUserInfo updateUserInfo,
            IQuitApplicationHandle quitApplicationHandle,
            IUpdate update)
        {
            _systemMessaging = systemMessaging;
            _checkUser = checkUser;
            _retrieveUserInput = retrieveUserInput;
            _checkPin = checkPin;
            _retrieveUserInfo = retrieveUserInfo;
            _mainMenu = mainMenu;
            _balanceUpdate = balanceUpdate;
            _updateUserInfo = updateUserInfo;
            _quitApplicationHandle = quitApplicationHandle;
            _update = update;
        }

        public void Run()
        {
            // User verification
            _systemMessaging.WelcomeMessage();
            _systemMessaging.UserNamePrompt();
            string userName = _retrieveUserInput.Input();
            _checkUser.Run(userName);
            _systemMessaging.PinPrompt();
            string pin = _retrieveUserInput.Input();
            _checkPin.Run(userName, pin);

            // User Info
            var userInfo = _retrieveUserInfo.Run(userName, pin);
            int userBalance = userInfo[0].Balance;
            int updatedBalance;

            // Main Control
            bool quit = false;
            do
            {
                var optionValueAndChoice = _mainMenu.Control();
                int optionValue = optionValueAndChoice.Item1;
                int optionChoice = optionValueAndChoice.Item2;
                string updatedBalanceString;
                switch (optionChoice)
                {
                    case 1:
                        // Update Withdraw Balance
                        updatedBalance = _update.Run(userBalance, optionValue, optionChoice);
                        updatedBalanceString = updatedBalance.ToString();
                        _updateUserInfo.Run(userName, pin, updatedBalanceString);
                        userBalance = updatedBalance;
                        break;
                    case 2:
                        // Update Deposit Balance
                        updatedBalance = _update.Run(userBalance, optionValue, optionChoice);
                        updatedBalanceString = updatedBalance.ToString();
                        _updateUserInfo.Run(userName, pin, updatedBalanceString);
                        userBalance = updatedBalance;
                        break;
                    case 3:
                        // Display Balance
                        string userBalanceReadable = userBalance.ToString("C", CultureInfo.CurrentCulture);
                        _systemMessaging.DisplayBalance(userBalanceReadable);
                        break;
                    case 4:
                        // Quit
                        _systemMessaging.SystemExitMessage();
                        System.Environment.Exit(1);
                        break;
                }

                // Continuation prompt and selection
                bool quitPromptValid = false;
                string quitOptionSelection;
                quit = _quitApplicationHandle.Run(quit, out quitPromptValid, out quitOptionSelection);

            } while (quit == false);
        }
    }
}
