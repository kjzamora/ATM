using System;
using System.Collections.Generic;
using ATM.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemMessaging.WelcomeMessage();

            IDataAccess _data = Instantiate.CreateDataAccess();
            string connection = MySQLConnection.Connection();

            List<UserModel> userQuery;

            // Get username
            bool valid;
            string userName = SystemMessaging.UserNamePrompt();
            for (int i = 0; i <= 3; i++)
            {
                string verifyUser = Query.VerifyUser($"{ userName }");
                userQuery = _data.LoadData<UserModel, dynamic>(verifyUser, new { }, connection);
                valid = QueryIsNullOrNot("Invalid username, please try again", userQuery);
                if (i == 3)
                {
                    SystemMessaging.ExceededLoginAttempts();
                    SystemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                }
                else if (valid == false)
                {
                    SystemMessaging.InvalidUser(userName);
                    userName = SystemMessaging.UserNamePrompt();
                }
                else
                {
                    break;
                }
                
            }

            // Get pin number
            string pin = SystemMessaging.PinPrompt(); 
            for (int i = 0; i <= 3; i++)
            {
                string verifyUserAndPin = Query.VerifyPin(userName, pin);
                userQuery = _data.LoadData<UserModel, dynamic>(verifyUserAndPin, new { }, connection);
                valid = QueryIsNullOrNot("Invalid pin, please try again", userQuery);
                if (i == 3)
                {
                    SystemMessaging.ExceededLoginAttempts();
                    SystemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                }
                else if (valid == false)
                {
                    SystemMessaging.Pin(pin);
                    pin = SystemMessaging.PinPrompt();
                }
                else
                {
                    break;
                }

            }

            //foreach (var acc in userQuery)
            //{
            //    Console.WriteLine(acc.UserName);
            //    Console.WriteLine(acc.Balance);
            //}


            // Verify username exist
            //try
            //{
            //    if (userQuery != null || userQuery.Count != 0)
            //    {
            //        //return userQuery;
            //    }
            //}

            //catch
            //{
            //    Console.Write("Invalid Username.");
            //}

            // Write username to console
            //foreach (var acc in userQuery)
            //{
            //    Console.WriteLine(acc.UserName);
            //}

            // Bring data in locally
            //List <UserModel> userQuery;
            //string sql = Query.UserData($"{ userName }", "2222");
            //string MySqlBaseConnectionStringBuilder = @"server=localhost; database=usersdb; user id=DBAdmin; password=admin;";

            //try
            //{
            //    userQuery = _data.LoadData<UserModel, dynamic>(sql, new { }, connection);
            //    // add error handling
            //    foreach (var acc in userQuery)
            //    {
            //        Console.WriteLine(acc.UserName);
            //        Console.WriteLine(acc.Balance);
            //    }
            //}

            //catch (MySqlException err)
            //{
            //    Console.Write(err);
            //}

            //Console.Read();







        }
        public static bool QueryIsNullOrNot(string message, List<UserModel> userModelObj)
        {
            Console.WriteLine(message);

            if (userModelObj.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
