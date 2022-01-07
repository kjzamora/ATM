using System;

namespace ATM
{
    public class RetrieveUserCustomWithdrawInput : IRetrieveUserCustomWithdrawInput
    {
        ISystemMessaging _systemMessaging;

        public RetrieveUserCustomWithdrawInput(ISystemMessaging systemMessaging)
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
                _systemMessaging.CustomWithdraw();
                line = Console.ReadLine();

                if (int.TryParse(line, out value))
                {
                    if (value > 0 && value < int.MaxValue)
                    {
                        done = true;
                        break;
                    }
                    else
                    {
                        _systemMessaging.InvalidCustomWithdraw();
                    }
                }
                else
                {
                    _systemMessaging.InvalidCustomWithdraw();
                }
            }
            while (done == false);
            return value;
        }
    }
}
