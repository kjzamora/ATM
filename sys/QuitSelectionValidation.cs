namespace ATM
{
    public class QuitSelectionValidation : IQuitSelectionValidation
    {
        ISystemMessaging _systemMessaging;

        public QuitSelectionValidation(ISystemMessaging systemMessaging)
        {
            _systemMessaging = systemMessaging;
        }

        public bool Run(bool quit, string quitOptionSelection)
        {
            // check if valid selection
            if (quitOptionSelection == "1" || quitOptionSelection == "2")
            {
                quit = true;
            }
            else
            {
                _systemMessaging.InvalidSelection();
            }

            return quit;
        }
    }
}