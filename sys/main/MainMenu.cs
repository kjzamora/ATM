﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class MainMenu : IMainMenu
    {
        IMainMenuOptions _mainMenuOptions;
        IMainMenuOptionsMessaging _mainMenuOptionsMessaging;
        IRetrieveUserMainMenuInput _retrieveUserMainMenuInput;

        public MainMenu(IMainMenuOptions mainMenuOptions, IMainMenuOptionsMessaging mainMenuOptionsMessaging, IRetrieveUserMainMenuInput retrieveUserMainMenuInput)
        {
            _mainMenuOptions = mainMenuOptions;
            _mainMenuOptionsMessaging = mainMenuOptionsMessaging;
            _retrieveUserMainMenuInput = retrieveUserMainMenuInput;
        }
        public (int, int) Control()
        {
            _mainMenuOptionsMessaging.UserOptions();
            int mainMenuOption = _retrieveUserMainMenuInput.Input();
            var optionValueAndChoice = _mainMenuOptions.Selection(mainMenuOption);
            return optionValueAndChoice;
        }
    }
}
