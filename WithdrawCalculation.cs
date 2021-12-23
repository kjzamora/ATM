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
                // Add connection page to withdraw options. Page should handle withdraw program flow
            }
            else
            {
                return currBalance - amount; 
            }

            return currBalance - amount; //temp - just to compile. remove later; bad coding
        }
    }
}
