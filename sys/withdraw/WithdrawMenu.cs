namespace ATM
{
    public class WithdrawMenu : IWithdrawMenu
    {
        IRetrieveUserCustomInput _retrieveUserCustomInput;
        IRetrieveWithdrawOrDepositOption _retrieveWithdrawOrDepositOption;
        ISystemMessaging _systemMessaging;

        public WithdrawMenu(IRetrieveUserCustomInput retrieveUserCustomInput, IRetrieveWithdrawOrDepositOption retrieveWithdrawOrDepositOption, ISystemMessaging systemMessaging)
        {
            _retrieveUserCustomInput = retrieveUserCustomInput;
            _retrieveWithdrawOrDepositOption = retrieveWithdrawOrDepositOption;
            _systemMessaging = systemMessaging;
        }

        public int Control()
        {
            _systemMessaging.QuickSelectionOptions();
            int withdrawMenuOption = _retrieveWithdrawOrDepositOption.Input();
            int withdrawOptionAmount;
            if (withdrawMenuOption < 6)
            {
                withdrawOptionAmount = QuickSelectionOptions.Amount(withdrawMenuOption);
            }
            else
            {
                withdrawOptionAmount = _retrieveUserCustomInput.Input();
            }
            return withdrawOptionAmount;
        }
    }
}
