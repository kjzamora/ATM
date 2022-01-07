

namespace ATM
{
    public class BalanceUpdate : IBalanceUpdate
    {
        IWithdrawCalculation _withdrawCalculation;

        public BalanceUpdate(IWithdrawCalculation withdrawCalculation)
        {
            _withdrawCalculation = withdrawCalculation;
        }

        public int Run(int userBalance, int optionValue, int optionChoice)
        {
            int updatedBalance = 0;
            if (optionChoice == 1)
            {
                updatedBalance = _withdrawCalculation.Calc(userBalance, optionValue);
            }
            else if (optionChoice == 3)
            {
                // deposit
            }

            return updatedBalance;
        }
    }
}