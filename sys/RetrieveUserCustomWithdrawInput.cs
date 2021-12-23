using System;

namespace ATM
{
    class RetrieveUserCustomWithdrawInput
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
                    if (value > 0 && value < int.MaxValue)
                    {
                        done = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Please try again");
                        Console.WriteLine();
                        Console.Write("Amount: ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again");
                    Console.WriteLine();
                    Console.Write("Amount: ");
                }
            }
            while (done == false);
            return value;
        }
    }
}
