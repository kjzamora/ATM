namespace ATM
{
    public class RetrieveUserMainMenuInput : IRetrieveUserMainMenuInput
    {
        IRetrieveUserInput _retrieveUserInput;
        ISystemMessaging _systemMessaging;

        public RetrieveUserMainMenuInput(IRetrieveUserInput retrieveUserInput, ISystemMessaging systemMessaging)
        {
            _retrieveUserInput = retrieveUserInput;
            _systemMessaging = systemMessaging;
        }

        public int Input()
        {
            int value;
            bool done = false;
            string line;
            do
            {
                line = _retrieveUserInput.Input();
                if (int.TryParse(line, out value))
                {
                    if (value > 0 && value < 6)
                    {
                        done = true;
                        break;
                    }
                    else
                    {
                        _systemMessaging.InvalidSelection();
                    }
                }
                else
                {
                    _systemMessaging.InvalidSelection();
                }
            }
            while (done == false);
            return value;
        }
    }
}
