using ATM.Models;
using System;
using System.Collections.Generic;

namespace ATM
{
    public class CheckClass
    {

        internal static bool QueryIsNullOrNot(string message, List<UserModel> userModelObj)
        {
            if (userModelObj.Count != 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine(message);
                return false;
            }
        }

        public static List<UserModel> UserNameCheck(IDataAccess _data, string connection, ref List<UserModel> userQuery, ref string userName)
        {
            bool valid;
            for (int i = 0; i <= 2; i++)
            {
                string checkUser = Query.CheckUser($"{ userName }");
                userQuery = _data.LoadData<UserModel, dynamic>(checkUser, new { }, connection);
                valid = QueryIsNullOrNot("Invalid username, please try again", userQuery);
                if (i == 2)
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
                    return userQuery;
                }
            }
            return userQuery = null;
        }

        public static List<UserModel> PinCheck(IDataAccess _data, string connection, ref List<UserModel> userQuery, ref string userName, ref string pin)
        {
            bool valid;
            for (int i = 0; i <= 2; i++)
            {
                string checkUserPin = Query.CheckPin($"{ userName }", $"{ pin }");
                userQuery = _data.LoadData<UserModel, dynamic>(checkUserPin, new { }, connection);
                valid = QueryIsNullOrNot("Invalid username, please try again", userQuery);
                if (i == 2)
                {
                    SystemMessaging.ExceededLoginAttempts();
                    SystemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                }
                else if (valid == false)
                {
                    SystemMessaging.InvalidPin(userName);
                    userName = SystemMessaging.PinPrompt();
                }
                else
                {
                    return userQuery;
                }
            }
            return userQuery = null;
        }
    }
}