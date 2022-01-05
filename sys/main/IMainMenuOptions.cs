namespace ATM
{
    public interface IMainMenuOptions
    {
        (int optionAmount, int optionChoice) Selection(int selection);
    }
}