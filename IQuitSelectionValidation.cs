namespace ATM
{
    public interface IQuitSelectionValidation
    {
        bool Run(bool quit, string quitOptionSelection);
    }
}