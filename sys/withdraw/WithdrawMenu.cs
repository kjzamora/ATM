﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class WithdrawMenu : IWithdrawMenu
    {
        IRetrieveUserCustomWithdrawInput _retrieveUserCustomWithdrawInput;
        IRetrieveWithdrawOrDepositOption _retrieveWithdrawOrDepositOption;
        ISystemMessaging _systemMessaging;

        public WithdrawMenu(IRetrieveUserCustomWithdrawInput retrieveUserCustomWithdrawInput, IRetrieveWithdrawOrDepositOption retrieveWithdrawOrDepositOption, ISystemMessaging systemMessaging)
        {
            _retrieveUserCustomWithdrawInput = retrieveUserCustomWithdrawInput;
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
                withdrawOptionAmount = _retrieveUserCustomWithdrawInput.Input();
            }
            return withdrawOptionAmount;
        }
    }
}
