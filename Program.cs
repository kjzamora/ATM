using System;
using System.Collections.Generic;
using ATM.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System.Threading.Tasks;
using Autofac;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();

            //// Startup
            //SystemMessaging.WelcomeMessage();
            //IDataAccess _data = Instantiate.CreateDataAccess(); // Create MySQL connection
            //string connection = MySQLConnection.Connection(); // Create MySQL connection

            //// Login Verification
            //List<UserModel> userQuery = null;
            //string userName = SystemMessaging.UserNamePrompt(); // Get username from user input
            //userQuery = CheckClass.UserNameCheck(_data, connection, ref userQuery, ref userName); // Verify username
            //string pin = SystemMessaging.PinPrompt(); // Get pin number from user input
            //userQuery = CheckClass.PinCheck(_data, connection, ref userQuery, ref userName, ref pin); // Verify pin

            //// Retrieve all user data
            //string sql = Query.UserData($"{ userName }", $"{ pin }");
            //userQuery = _data.LoadData<UserModel, dynamic>(sql, new { }, connection);

            //// Add user selection options
            //MainMenu.Control();

            //// Update balance based on previous selection
            ////int balanceUpdated = WithdrawCalculation.Calc(userQuery, );

            ////balanceUpdated = Query.UpdateBalance(userName, pin, balanceUpdated);
            ////_data.SaveData(balanceUpdated, new { }, connection);


            ////Console.Read();

            ////foreach (var acc in userQuery)
            ////{
            ////    Console.WriteLine(acc.UserName);
            ////    Console.WriteLine(acc.Balance);
            ////}
        }
    }
}
