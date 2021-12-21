using System;

namespace ATM
{
    public class SystemMessaging
    {
        public static void WelcomeMessage()
        {
             Console.WriteLine("-----Welcome to ATM-----\n\n");
        }

        public static string UserNamePrompt()
        {
            Console.Write("User:  ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            return userName;
        }

        public static string InvalidUser(string userName)
        {
            return $"This username '{ userName }' does not exist. Please try again.";
        }

        public static string PinPrompt()
        {
            Console.Write("Pin:  ");
            string pin = Console.ReadLine();
            Console.WriteLine();
            return pin;
        }

        public static string Pin(string pin)
        {
            return $"This username '{ pin }' does not exist. Please try again.";
        }

        public static void ExceededLoginAttempts()
        {
            Console.WriteLine("You have exceeded the number of attempts you can login. You're account will now be locked.");
            Console.WriteLine("To restore your accounts access, please contact your Administrator");
        }

        public static void SystemExitMessage()
        {
            Console.WriteLine("System connection will now close.");
        }
    }
}