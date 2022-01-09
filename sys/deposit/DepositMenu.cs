namespace ATM
{
    public class DepositMenu : IDepositMenu
    {
        IRetrieveUserCustomInput _retrieveUserCustomInput;
        IRetrieveWithdrawOrDepositOption _retrieveWithdrawOrDepositOption;
        ISystemMessaging _systemMessaging;

        public DepositMenu(IRetrieveUserCustomInput retrieveUserCustomInput, IRetrieveWithdrawOrDepositOption retrieveWithdrawOrDepositOption, ISystemMessaging systemMessaging)
        {
            _retrieveUserCustomInput = retrieveUserCustomInput;
            _retrieveWithdrawOrDepositOption = retrieveWithdrawOrDepositOption;
            _systemMessaging = systemMessaging;
        }

        public int Control()
        {
            _systemMessaging.QuickSelectionOptions();
            int depositMenuOption = _retrieveWithdrawOrDepositOption.Input();
            int depositOptionAmount;
            if (depositMenuOption < 6)
            {
                depositOptionAmount = QuickSelectionOptions.Amount(depositMenuOption);
            }
            else
            {
                depositOptionAmount = _retrieveUserCustomInput.Input();
            }
            return depositOptionAmount;
        }
    }
}
