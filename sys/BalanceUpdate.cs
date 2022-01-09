

namespace ATM
{
    public class BalanceUpdate : IBalanceUpdate
    {
        IWithdrawCalculation _withdrawCalculation;
        IDepositCalculation _depositCalculation;

        public BalanceUpdate(IWithdrawCalculation withdrawCalculation, IDepositCalculation depositCalculation)
        {
            _withdrawCalculation = withdrawCalculation;
            _depositCalculation = depositCalculation;
        }

        public int Run(int userBalance, int optionValue, int optionChoice)
        {
            int updatedBalance = 0;
            if (optionChoice == 1)
            {
                updatedBalance = _withdrawCalculation.Calc(userBalance, optionValue);
            }
            else if (optionChoice == 2)
            {
                // transfer
            }
            else if (optionChoice == 3)
            {
                updatedBalance = _depositCalculation.Calc(userBalance, optionValue);
            }

            return updatedBalance;
        }
    }
}