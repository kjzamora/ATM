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

        public Application(IDataAccess dataAccess, ISystemMessaging systemMessaging, ICheckUser checkUser, IRetrieveUserInput retrieveUserInput, ICheckPin checkPin, IRetrieveUserInfo retrieveUserInfo, IMainMenu mainMenu)
        {
            _dataAccess = dataAccess;
            _systemMessaging = systemMessaging;
            _checkUser = checkUser;
            _retrieveUserInput = retrieveUserInput;
            _checkPin = checkPin;
            _retrieveUserInfo = retrieveUserInfo;
            _mainMenu = mainMenu;
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
            _retrieveUserInfo.Run(userName, pin);
            _mainMenu.Control();

        }
    }
}
