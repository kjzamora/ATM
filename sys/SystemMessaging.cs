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
            //string userName = Console.ReadLine(); // refactor... system messaging should not handle console readline operations
            //Console.WriteLine();
            //return userName;
        }

        public string InvalidUser(string userName)
        {
            return $"This username '{ userName }' does not exist. Please try again."; // refactor...
        }

        public string PinPrompt()
        {
            Console.Write("Pin:  ");
            string pin = Console.ReadLine(); // refactor...
            Console.WriteLine();
            return pin;
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

        public void SystemExitMessage()
        {
            Console.WriteLine("System connection will now close.");
            Console.WriteLine();
            Console.WriteLine("Have a great day!");
        }
    }
}