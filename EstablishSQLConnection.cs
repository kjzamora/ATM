using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class EstablishSQLConnection : IEstablishSQLConnection
    {
        IMySQLConnection _mySQLConnection;
        IQueryString _queryString;
        IDataAccess _dataAccess;
        IRetrieveUserInput _retrieveUserInput;

        public EstablishSQLConnection(IMySQLConnection mySQLConnection, IQueryString queryString, IDataAccess dataAccess, IRetrieveUserInput retrieveUserInput)
        {
            _mySQLConnection = mySQLConnection;
            _queryString = queryString;
            _dataAccess = dataAccess;
            _retrieveUserInput = retrieveUserInput;
        }

        public void RunQuery()
        {
            //List<IUserModel> user = null;
            string username = _retrieveUserInput.Input();
            string sql = _queryString.CheckUser($"{ username }");
            string connection = _mySQLConnection.Connection();
            List<UserModel> userQuery = _dataAccess.LoadData<UserModel, dynamic>(sql, new { }, connection); // using IUserMode here doesnt work???
            //userQuery = _data.LoadData<UserModel, dynamic>(sql, new { }, connection);
        }

    }
}
