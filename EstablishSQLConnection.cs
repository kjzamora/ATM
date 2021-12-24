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
        //IUserModel _userModel;
        IDataAccess _dataAccess;

        public EstablishSQLConnection(IMySQLConnection mySQLConnection, IQueryString queryString, IDataAccess dataAccess)
        {
            _mySQLConnection = mySQLConnection;
            _queryString = queryString;
            _dataAccess = dataAccess;
            //_userModel = userModel;
        }

        public void RunQuery()
        {
            List<IUserModel> user = null;
            string sql = _queryString.CheckUser("therock");
            string connection = _mySQLConnection.Connection();
            List<UserModel> userQuery = _dataAccess.LoadData<UserModel, dynamic>(sql, new { }, connection);
            //userQuery = _data.LoadData<UserModel, dynamic>(sql, new { }, connection);
        }

    }
}
