namespace ATM
{
    public interface IQuitApplicationHandle
    {
        bool Run(bool quit, out bool quitPromptValid, out string quitOptionSelection, int sleep);
    }
}