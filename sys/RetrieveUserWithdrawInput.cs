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
                        Console.WriteLine("Invalid selection. Please try again");
                        Console.WriteLine();
                        Console.Write("Option: ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again");
                    Console.WriteLine();
                    Console.Write("Option: ");
                }
            }
            while (done == false);
            return value;
        }
    }
}
