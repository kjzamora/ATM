using System;

namespace ATM
{
    public class MainMenu : IMainMenu
    {
        IMainMenuOptions _mainMenuOptions;
        ISystemMessaging _systemMessaging;
        IRetrieveUserMainMenuInput _retrieveUserMainMenuInput;

        public MainMenu(IMainMenuOptions mainMenuOptions, IRetrieveUserMainMenuInput retrieveUserMainMenuInput, ISystemMessaging systemMessaging)
        {
            _mainMenuOptions = mainMenuOptions;
            _systemMessaging = systemMessaging;
            _retrieveUserMainMenuInput = retrieveUserMainMenuInput;
        }
        public (int, int) Control()
        {
            Console.Clear();
            _systemMessaging.MainMenuUserOptions();
            int mainMenuOption = _retrieveUserMainMenuInput.Input();
            var optionValueAndChoice = _mainMenuOptions.Selection(mainMenuOption);
            return optionValueAndChoice;
        }
    }
}
