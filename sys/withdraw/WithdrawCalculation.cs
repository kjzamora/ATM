namespace ATM
{
    public class WithdrawCalculation : IWithdrawCalculation
    {
        ISystemMessaging _systemMessaging;

        public WithdrawCalculation(ISystemMessaging systemMessaging)
        {
            _systemMessaging = systemMessaging;
        }
        public int Calc(int userBalance, int amount)
        {

            if (userBalance < 0 || userBalance - amount < 0)
            {
                _systemMessaging.InsufficientFunds();
                return userBalance;
            }

            return userBalance - amount;
        }
    }
}
