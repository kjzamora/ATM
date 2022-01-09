using System;

namespace ATM
{
    public class RetrieveWithdrawOrDepositOption : IRetrieveWithdrawOrDepositOption
    {
        ISystemMessaging _systemMessaging;

        public RetrieveWithdrawOrDepositOption(ISystemMessaging systemMessaging)
        {
            _systemMessaging = systemMessaging;
        }

        public int Input()
        {
            int value;
            bool done = false;
            string line;
            do
            {
                line = Console.ReadLine();
                if (int.TryParse(line, out value))
                {
                    if (value > 0 && value < 7)
                    {
                        done = true;
                        break;
                    }
                    else
                    {
                        _systemMessaging.InvalidSelection();
                    }
                }
                else
                {
                    _systemMessaging.InvalidSelection();
                }
            }
            while (done == false);
            return value;
        }
    }
}
