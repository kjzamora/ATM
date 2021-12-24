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

        public Application(IDataAccess dataAccess, ISystemMessaging systemMessaging)
        {
            _dataAccess = dataAccess;
            _systemMessaging = systemMessaging;
        }

        public void Run()
        {
            _systemMessaging.WelcomeMessage();

            List<UserModel> userQuery;
            string connection = MySQLConnection.Connection();
            //string sql = Query.UserData($"{ userName }", $"{ pin }");
            string sql = Query.UserData("therock", "2222");
            userQuery = _dataAccess.LoadData<UserModel, dynamic>(sql, new { }, connection);
        }
    }
}
