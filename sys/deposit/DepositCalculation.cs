namespace ATM
{
    public class DepositCalculation : IDepositCalculation
    {
        public int Calc(int userBalance, int amount)
        {
            return userBalance + amount;
        }
    }
}
