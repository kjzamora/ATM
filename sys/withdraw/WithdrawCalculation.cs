using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class WithdrawCalculation
    {
        public static int Calc(int userBalance, int amount)
        {
            // Current balance
            if (userBalance < 0 || userBalance - amount < 0)
            {
                Console.WriteLine("Insufficient funds.");
                return userBalance;
                //WithdrawMenu.Control(); // not sure if this is best practice... feel like it should throw an error and return control back to main instead...
            }

            return userBalance - amount; 
        }
    }
}
