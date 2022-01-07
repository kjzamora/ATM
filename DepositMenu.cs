using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class DepositMenu : IDepositMenu
    {
        IRetrieveUserCustomWithdrawInput _retrieveUserCustomWithdrawInput;
        IRetrieveWithdrawOrDepositOption _retrieveWithdrawOrDepositOption;
        ISystemMessaging _systemMessaging;

        public DepositMenu(IRetrieveUserCustomWithdrawInput retrieveUserCustomWithdrawInput, IRetrieveWithdrawOrDepositOption retrieveWithdrawOrDepositOption, ISystemMessaging systemMessaging)
        {
            _retrieveUserCustomWithdrawInput = retrieveUserCustomWithdrawInput;
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
                depositOptionAmount = _retrieveUserCustomWithdrawInput.Input();
            }
            return depositOptionAmount;
        }
    }
}
