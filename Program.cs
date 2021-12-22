using System;
using System.Collections.Generic;
using ATM.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemMessaging.WelcomeMessage();

            IDataAccess _data = Instantiate.CreateDataAccess();
            string connection = MySQLConnection.Connection();

            // Get username
            List<UserModel> userQuery = null;
            string userName = SystemMessaging.UserNamePrompt();
            userQuery = CheckClass.UserNameCheck(_data, connection, ref userQuery, ref userName);

            // Get pin number
            string pin = SystemMessaging.PinPrompt();
            userQuery = CheckClass.PinCheck(_data, connection, ref userQuery, ref userName, ref pin);

            // Retrieve all user data
            string sql = Query.UserData($"{ userName }", $"{ pin }");
            userQuery = _data.LoadData<UserModel, dynamic>(sql, new { }, connection);

            Console.Read();

            //foreach (var acc in userQuery)
            //{
            //    Console.WriteLine(acc.UserName);
            //    Console.WriteLine(acc.Balance);
            //}
        }
    }
}
