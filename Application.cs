using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Application : IApplication
    {
        IDataAccess _dataAccess;
        ISystemMessaging _systemMessaging;
        ICheckUser _checkUser;
        IRetrieveUserInput _retrieveUserInput;
        ICheckPin _checkPin;
        IRetrieveUserInfo _retrieveUserInfo;
        IMainMenu _mainMenu;
        IQueryString _queryString;
        IBalanceUpdate _balanceUpdate;
        IUpdateUserInfo _updateUserInfo;
        IQuitSelectionValidation _quitSelectionValidation;

        public Application(
            IDataAccess dataAccess,
            ISystemMessaging systemMessaging,
            ICheckUser checkUser,
            IRetrieveUserInput retrieveUserInput,
            ICheckPin checkPin,
            IRetrieveUserInfo retrieveUserInfo,
            IMainMenu mainMenu,
            IQueryString queryString,
            IBalanceUpdate balanceUpdate,
            IUpdateUserInfo updateUserInfo,
            IQuitSelectionValidation quitSelectionValidation)
        {
            _dataAccess = dataAccess;
            _systemMessaging = systemMessaging;
            _checkUser = checkUser;
            _retrieveUserInput = retrieveUserInput;
            _checkPin = checkPin;
            _retrieveUserInfo = retrieveUserInfo;
            _mainMenu = mainMenu;
            _queryString = queryString;
            _balanceUpdate = balanceUpdate;
            _updateUserInfo = updateUserInfo;
            _quitSelectionValidation = quitSelectionValidation;
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
                do
                {
                    var optionValueAndChoice = _mainMenu.Control();
                    int optionValue = optionValueAndChoice.Item1;
                    int optionChoice = optionValueAndChoice.Item2;
                    updatedBalance = _balanceUpdate.Run(userBalance, optionValue, optionChoice);
                    if (userBalance == updatedBalance)
                    {
                        _systemMessaging.MainReprompt();
                    }

                } while (userBalance == updatedBalance);

                // Update balance
                string updatedBalanceString = updatedBalance.ToString();
                _updateUserInfo.Run(userName, pin, updatedBalanceString);

                // Quit prompt and selection
                bool quitPromptValid = false;
                string quitOptionSelection;
                do
                {
                    _systemMessaging.QuitPrompt();
                    quitOptionSelection = _retrieveUserInput.Input();
                    quitPromptValid = _quitSelectionValidation.Run(quit, quitOptionSelection);

                } while (quitPromptValid == false);

                if (quitOptionSelection == "2" )
                {
                    quit = true;
                    _systemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                }

            } while (quit == false);
        }
    }
}
