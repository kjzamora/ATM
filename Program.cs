using System;

namespace ATM
{
    class Program : SystemMessaging
    {
        static void Main(string[] args)
        {
            SystemMessaging.WelcomeMessage();

            Console.Write("User:  ");
            string user = Console.ReadLine();

            Console.Write("Password:  ");
            string password = Console.ReadLine();

            //verify user acc and password

        }
    }
}
