using ATM.Models;
using System;
using System.Collections.Generic;

namespace ATM
{
    public class CheckUser : ICheckUser
    {
        ISystemMessaging _systemMessaging;
        IQueryString _queryString;
        IRetrieveUserInput _retrieveUserInput;
        IMySQLConnection _mySQLConnection;
        IDataAccess _dataAccess;

        public CheckUser(ISystemMessaging systemMessaging, IQueryString queryString, IRetrieveUserInput retrieveUserInput, IMySQLConnection mySQLConnection, IDataAccess dataAccess)
        {
            _systemMessaging = systemMessaging;
            _queryString = queryString;
            _retrieveUserInput = retrieveUserInput;
            _mySQLConnection = mySQLConnection;
            _dataAccess = dataAccess;
        }

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

        public List<UserModel> Run(string userName)
        {
            bool valid;
            int i = 0;
            List<UserModel> userQuery;
            do
            {
                string checkUser = _queryString.CheckUser($"{ userName }");
                string connection = _mySQLConnection.Connection();
                userQuery = _dataAccess.LoadData<UserModel, dynamic>(checkUser, new { }, connection);
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
                    _systemMessaging.UserNamePrompt();
                    userName = _retrieveUserInput.Input();
                }
                else
                {
                    break;
                }
                i++;
            }
            while (i < 3);
            return userQuery;
        }
    }
}