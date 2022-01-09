namespace ATM
{
    public interface ISystemMessaging
    {
        void ExceededLoginAttempts();
        void InvalidPin();
        string InvalidUser(string userName);
        void PinPrompt();
        void SystemExitMessage();
        void UserNamePrompt();
        void WelcomeMessage();
        void InsufficientFunds();
        void MainReprompt();
        void CustomWithdraw();
        void InvalidCustomWithdraw();
        void InvalidSelection();
        void QuitPrompt();
        void QuickSelectionOptions();
        void DisplayBalance(string userBalanceReadable);
        void MainMenuUserOptions();
    }
}