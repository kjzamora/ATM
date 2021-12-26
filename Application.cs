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
        IEstablishSQLConnection _establishSQLConnection;

        public Application(IDataAccess dataAccess, ISystemMessaging systemMessaging, IEstablishSQLConnection establishSQLConnection)
        {
            _dataAccess = dataAccess;
            _systemMessaging = systemMessaging;
            _establishSQLConnection = establishSQLConnection;
        }

        public void Run()
        {
            _systemMessaging.WelcomeMessage();
            _systemMessaging.UserNamePrompt();
            _establishSQLConnection.RunQuery();


            //List<UserModel> userQuery;
            //string connection = MySQLConnection.Connection();
            ////string sql = Query.UserData($"{ userName }", $"{ pin }");
            //string sql = QueryString.UserData("therock", "2222");
            //userQuery = _dataAccess.LoadData<UserModel, dynamic>(sql, new { }, connection);
        }
    }
}
