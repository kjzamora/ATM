namespace ATM
{
    public interface ISystemMessaging
    {
        void ExceededLoginAttempts();
        void InvalidPin();
        string InvalidUser(string userName);
        string PinPrompt();
        void SystemExitMessage();
        void UserNamePrompt();
        void WelcomeMessage();
    }
}