namespace ATM
{
    public interface IBalanceUpdate
    {
        int Run(int userBalance, int optionValue, int optionChoice);
    }
}