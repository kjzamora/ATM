using ATM.Models;
using System;
using System.Collections.Generic;

namespace ATM
{
    public class CheckPin : ICheckPin
    {
        ISystemMessaging _systemMessaging;
        IQueryString _queryString;
        IRetrieveUserInput _retrieveUserInput;
        IMySQLConnection _mySQLConnection;
        IDataAccess _dataAccess;

        public CheckPin(ISystemMessaging systemMessaging, IQueryString queryString, IRetrieveUserInput retrieveUserInput, IMySQLConnection mySQLConnection, IDataAccess dataAccess)
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

        public List<UserModel> Run(string userName, string pin)
        {
            bool valid;
            int i = 0;
            List<UserModel> userQuery;
            do
            {
                string checkUserPin = _queryString.CheckPin($"{ userName }", $"{ pin }");
                string connection = _mySQLConnection.Connection();
                userQuery = _dataAccess.LoadData<UserModel, dynamic>(checkUserPin, new { }, connection);
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
                    _systemMessaging.PinPrompt();
                    pin = _retrieveUserInput.Input();
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
