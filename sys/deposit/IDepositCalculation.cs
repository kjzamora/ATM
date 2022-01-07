namespace ATM
{
    public interface IDepositCalculation
    {
        int Calc(int userBalance, int amount);
    }
}