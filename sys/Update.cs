namespace ATM
{
    public class Update : IUpdate
    {
        IBalanceUpdate _balanceUpdate;
        ISystemMessaging _systemMessaging;

        public Update(IBalanceUpdate balanceUpdate, ISystemMessaging systemMessaging)
        {
            _balanceUpdate = balanceUpdate;
            _systemMessaging = systemMessaging;
        }
        public int Run(int userBalance, int optionValue, int optionChoice)
        {
            int updatedBalance = _balanceUpdate.Run(userBalance, optionValue, optionChoice);
            if (userBalance == updatedBalance)
            {
                _systemMessaging.MainReprompt();
            }

            return updatedBalance;
        }
    }
}