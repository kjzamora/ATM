using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Application : IApplication
    {
        IDataAccess _dataAccess;
        ISystemMessaging _systemMessaging;
        ICheckUser _checkUser;
        IRetrieveUserInput _retrieveUserInput;
        ICheckPin _checkPin;

        public Application(IDataAccess dataAccess, ISystemMessaging systemMessaging, ICheckUser checkUser, IRetrieveUserInput retrieveUserInput, ICheckPin checkPin)
        {
            _dataAccess = dataAccess;
            _systemMessaging = systemMessaging;
            _checkUser = checkUser;
            _retrieveUserInput = retrieveUserInput;
            _checkPin = checkPin;
        }

        public void Run()
        {
            _systemMessaging.WelcomeMessage();
            _systemMessaging.UserNamePrompt();
            string userName = _retrieveUserInput.Input();
            _checkUser.Run(userName);
            _systemMessaging.PinPrompt();
            string pin = _retrieveUserInput.Input();
            _checkPin.Run(userName, pin);


            //List<UserModel> userQuery;
            //string connection = MySQLConnection.Connection();
            ////string sql = Query.UserData($"{ userName }", $"{ pin }");
            //string sql = QueryString.UserData("therock", "2222");
            //userQuery = _dataAccess.LoadData<UserModel, dynamic>(sql, new { }, connection);
        }
    }
}
