namespace ATM
{
    public interface IWithdrawCalculation
    {
        int Calc(int userBalance, int amount);
    }
}