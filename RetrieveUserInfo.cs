using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class RetrieveUserInfo : IRetrieveUserInfo
    {
        IQueryString _queryString;
        IMySQLConnection _mySQLConnection;
        IDataAccess _dataAccess;

        public RetrieveUserInfo(IQueryString queryString, IMySQLConnection mySQLConnection, IDataAccess dataAccess)
        {
            _queryString = queryString;
            _mySQLConnection = mySQLConnection;
            _dataAccess = dataAccess;
        }

        public List<UserModel> Run(string userName, string pin)
        {
            List<UserModel> userQuery;
            string userInfo = _queryString.UserData($"{ userName }", $"{ pin }");
            string connection = _mySQLConnection.Connection();
            userQuery = _dataAccess.LoadData<UserModel, dynamic>(userInfo, new { }, connection);
            return userQuery;
        }
    }
}
