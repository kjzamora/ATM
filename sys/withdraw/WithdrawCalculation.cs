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
        public static int Calc(List<UserModel> user, int amount)
        {
            // Current balance
            int currBalance = user[0].Balance;
            if (currBalance < 0 || currBalance - amount < 0)
            {
                Console.WriteLine("Insufficient funds.");
                WithdrawMenu.Control(); // not sure if this is best practice... feel like it should throw an error and return control back to main instead...
            }

            return currBalance - amount; 
        }
    }
}
