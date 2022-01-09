namespace ATM
{
    public interface IUpdate
    {
        int Run(int userBalance, int optionValue, int optionChoice);
    }
}