using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class DepositCalculation : IDepositCalculation
    {
        public int Calc(int userBalance, int amount)
        {
            return userBalance + amount;
        }
    }
}
