namespace ATM
{
    public class QuitApplicationHandle : IQuitApplicationHandle
    {
        ISystemMessaging _systemMessaging;
        IRetrieveUserInput _retrieveUserInput;
        IQuitSelectionValidation _quitSelectionValidation;

        public QuitApplicationHandle(ISystemMessaging systemMessaging, IRetrieveUserInput retrieveUserInput, IQuitSelectionValidation quitSelectionValidation)
        {
            _systemMessaging = systemMessaging;
            _retrieveUserInput = retrieveUserInput;
            _quitSelectionValidation = quitSelectionValidation;
        }

        public bool Run(bool quit, out bool quitPromptValid, out string quitOptionSelection)
        {
            do
            {
                _systemMessaging.QuitPrompt();
                quitOptionSelection = _retrieveUserInput.Input();
                quitPromptValid = _quitSelectionValidation.Run(quit, quitOptionSelection);

            } while (quitPromptValid == false);

            if (quitOptionSelection == "2")
            {
                quit = true;
                _systemMessaging.SystemExitMessage();
                System.Environment.Exit(1);
            }

            return quit;
        }
    }
}