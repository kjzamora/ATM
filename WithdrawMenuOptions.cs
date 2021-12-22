using System;

namespace ATM
{
    public class WithdrawMenuOptions
    {

        public static string Selection(string mainMenuOption)
        {
            switch (mainMenuOption)
            {
                case "1":
                    string withdrawOption;
                    Console.WriteLine();
                    return withdrawOption = MainMenuOptions.WithdrawOption();
                    //break;
                case "2":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("This is not a valid option response");
                    break;
            }

            return withdrawOption;
        }
    }
}