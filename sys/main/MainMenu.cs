using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class MainMenu
    {
        IMainMenuOptions _mainMenuOptions;

        public MainMenu(IMainMenuOptions mainMenuOptions)
        {
            _mainMenuOptions = mainMenuOptions;
        }
        public void Control()
        {
            MainMenuOptionsMessaging.UserOptions();
            int mainMenuOption = RetrieveUserMainMenuInput.Input();
            _mainMenuOptions.Selection(mainMenuOption);
        }
    }
}
