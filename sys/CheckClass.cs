﻿using ATM.Models;
using System;
using System.Collections.Generic;

namespace ATM
{
    public class CheckClass
    {
        ISystemMessaging _systemMessaging;

        public CheckClass(ISystemMessaging systemMessaging)
        {
            _systemMessaging = systemMessaging;
        }
        // Should break out into 3 separate classes. Fails the Single Responsibility Principle
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

        public List<UserModel> UserNameCheck(IDataAccess _data, string connection, ref List<UserModel> userQuery, ref string userName)
        {
            bool valid;
            for (int i = 0; i <= 2; i++)
            {
                string checkUser = Query.CheckUser($"{ userName }");
                userQuery = _data.LoadData<UserModel, dynamic>(checkUser, new { }, connection);
                valid = QueryIsNullOrNot("Invalid username, please try again", userQuery);
                if (i == 2)
                {
                    _systemMessaging.ExceededLoginAttempts();
                    _systemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                }
                else if (valid == false)
                {
                    _systemMessaging.InvalidUser(userName);
                    userName = _systemMessaging.UserNamePrompt();
                }
                else
                {
                    return userQuery;
                }
            }
            return userQuery = null;
        }

        public List<UserModel> PinCheck(IDataAccess _data, string connection, ref List<UserModel> userQuery, ref string userName, ref string pin)
        {
            bool valid;
            for (int i = 0; i <= 2; i++)
            {
                string checkUserPin = Query.CheckPin($"{ userName }", $"{ pin }");
                userQuery = _data.LoadData<UserModel, dynamic>(checkUserPin, new { }, connection);
                valid = QueryIsNullOrNot("Invalid username, please try again", userQuery);
                if (i == 2)
                {
                    _systemMessaging.ExceededLoginAttempts();
                    _systemMessaging.SystemExitMessage();
                    System.Environment.Exit(1);
                }
                else if (valid == false)
                {
                    _systemMessaging.InvalidPin();
                    pin = _systemMessaging.PinPrompt();
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