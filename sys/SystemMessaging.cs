using System;
using System.Linq;

namespace ATM
{
    public class SystemMessaging : ISystemMessaging
    {

        public void WelcomeMessage()
        {
            // Ascii art generated from https://patorjk.com/software/taag/#p=display&w=%23&f=Slant%20Relief&t=ATM using Slant Relief font
            string textToEnter = @"
#############################################################################
####                                                                     ####
####                             WELCOME                                 ####
####                                                                     ####
#############################################################################

#############################################################################
#############################################################################
####_____/\\\\\\\\\_____/\\\\\\\\\\\\\\\__/\\\\____________/\\\\_############
#####___/\\\\\\\\\\\\\__\///////\\\/////__\/\\\\\\________/\\\\\\_###########
######__/\\\/////////\\\_______\/\\\_______\/\\\//\\\____/\\\//\\\_##########
#######_\/\\\_______\/\\\_______\/\\\_______\/\\\\///\\\/\\\/_\/\\\_#########
########_\/\\\\\\\\\\\\\\\_______\/\\\_______\/\\\__\///\\\/___\/\\\_########
#########_\/\\\/////////\\\_______\/\\\_______\/\\\____\///_____\/\\\_#######
##########_\/\\\_______\/\\\_______\/\\\_______\/\\\_____________\/\\\_######
###########_\/\\\_______\/\\\_______\/\\\_______\/\\\_____________\/\\\_#####
############_\///________\///________\///________\///______________\///__####
#############################################################################
#############################################################################
            ";
            var lines = textToEnter.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var longestLength = lines.Max(line => line.Length);
            var leadingSpaces = new string(' ', (Console.WindowWidth - longestLength) / 2);
            var centeredText = string.Join(Environment.NewLine,
                lines.Select(line => leadingSpaces + line));
            Console.WriteLine(centeredText);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void UserNamePrompt()
        {
            Console.WriteLine("Please enter your username");
            Console.WriteLine();
            Console.Write("User:  ");
        }

        public string InvalidUser(string userName)
        {
            return $"This username '{ userName }' does not exist. Please try again.";
        }

        public void PinPrompt()
        {
            Console.Write("Pin:  ");
        }

        public void InvalidPin()
        {
            Console.WriteLine("This pin you have entered does not work. Please try again.");
        }

        public void ExceededLoginAttempts()
        {
            Console.WriteLine("You have exceeded the number of attempts you can login. You're account will now be locked.");
            Console.WriteLine("To restore your accounts access, please contact your Administrator");
        }

        public void MainMenuUserOptions()
        {
            Console.WriteLine("Please select one of the following options:  ");
            Console.WriteLine();
            Console.WriteLine("     1 ---- Withdraw Cash");
            Console.WriteLine("     2 ---- Deposit Cash");
            Console.WriteLine("     3 ---- Display Balance");
            Console.WriteLine("     4 ---- Exit");
            Console.WriteLine();
            Console.Write("Option: ");
        }

        public void InsufficientFunds()
        {
            Console.WriteLine("Insufficient funds.");
        }

        public void MainReprompt()
        {
            Console.WriteLine("Please select another option.");
        }

        public void CustomWithdraw()
        {
            Console.Write("Please enter the amount you want to withdraw: ");
        }

        public void InvalidCustomWithdraw()
        {
            Console.WriteLine("Invalid selection. Please try again");
            Console.WriteLine();
            Console.Write("Amount: ");
        }

        public void InvalidSelection()
        {
            Console.WriteLine("Invalid selection. Please try again");
            Console.WriteLine();
            Console.Write("Option: ");
        }
        public void DisplayBalance(string userBalanceReadable)
        {
            Console.WriteLine();
            Console.WriteLine($"Your balance is: { userBalanceReadable }");
            Console.WriteLine();
        }

        public void QuickSelectionOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Please select any amount:  ");
            Console.WriteLine();
            Console.WriteLine("     1 ---- $20");
            Console.WriteLine("     2 ---- $40");
            Console.WriteLine("     3 ---- $60");
            Console.WriteLine("     4 ---- $80");
            Console.WriteLine("     5 ---- $100");
            Console.WriteLine("     6 ---- Other");
            Console.WriteLine();
            Console.Write("Option: ");
        }

        public void QuitPrompt()
        {
            Console.WriteLine("Would you like to make another transaction?: ");
            Console.WriteLine();
            Console.WriteLine("     1 ---- Yes");
            Console.WriteLine("     2 ---- No");
            Console.WriteLine();
            Console.Write("Option: ");
        }

        public void SystemExitMessage()
        {
            Console.WriteLine();
            Console.WriteLine("System connection will now close.");
            Console.WriteLine();
            Console.WriteLine("Have a great day!");
        }
    }
}