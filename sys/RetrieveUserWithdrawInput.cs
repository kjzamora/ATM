using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class RetrieveUserWithdrawInput
    {
        public static int Input()
        {
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                // this is an int 
                // do you minimum number check here
                if (value > 0 && value < 7)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again");
                    Input();
                }
            }
            else
            {
                // this is not an int
                Console.WriteLine("Invalid selection. Please try again");
                Input();
            }
            return -1;
        }
    }
}
