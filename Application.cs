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

        public Application(IDataAccess dataAccess, ISystemMessaging systemMessaging, ICheckUser checkUser, IRetrieveUserInput retrieveUserInput, ICheckPin checkPin, IRetrieveUserInfo retrieveUserInfo, IMainMenu mainMenu, IQueryString queryString)
        {
            _dataAccess = dataAccess;
            _systemMessaging = systemMessaging;
            _checkUser = checkUser;
            _retrieveUserInput = retrieveUserInput;
            _checkPin = checkPin;
            _retrieveUserInfo = retrieveUserInfo;
            _mainMenu = mainMenu;
            _queryString = queryString;
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

            // Main
            var userInfo = _retrieveUserInfo.Run(userName, pin);
            var optionValueAndChoice = _mainMenu.Control();

            // Check if withdraw calc
            int userBalance = userInfo[0].Balance;
            int optionValue = optionValueAndChoice.Item1;
            int optionChoice = optionValueAndChoice.Item2;
            int updatedBalance;

            //if (optionChoice == 1)
            //{
                updatedBalance = WithdrawCalculation.Calc(userBalance, optionValue);
            //}

            string updatedBalanceString = updatedBalance.ToString();
            _queryString.UpdateBalance(userName, pin, updatedBalanceString);

        }
    }
}
