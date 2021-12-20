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

            IDataAccess _data = new DataAccess();
            List<UserModel> user;
            string sql = "select * from tbluseraccount";
            string MySqlBaseConnectionStringBuilder = @"server=localhost; database=usersdb; user id=DBAdmin; password=admin;";

            try
            {
                user = _data.LoadData<UserModel, dynamic>(sql, new { }, MySqlBaseConnectionStringBuilder);
                foreach (var acc in user)
                {
                    Console.WriteLine(acc.UserName);
                    Console.WriteLine(acc.Balance);
                }
            }
            
            catch(MySqlException err)
            {
                Console.Write(err);
            }

            Console.Read();



        //string str = @"server=localhost;database=usersdb;user id=DBAdmin;password=admin;";
        //    MySqlConnection con = null;
        //    MySqlDataReader reader = null;
        //    try
        //    {
        //        con = new MySqlConnection(str);
        //        con.Open();
        //        Console.WriteLine("MySQL DB Connected");
        //        String cmdText = "SELECT * FROM tbluseraccount";
        //        MySqlCommand cmd = new MySqlCommand(cmdText, con);
        //        reader = cmd.ExecuteReader();
                
        //        while (reader.Read())
        //        {
        //            Console.WriteLine(reader.GetString(0));
        //        }
        //    }

        //    catch(MySqlException err)
        //    {
        //        Console.Write(err);
        //    }

        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }

        //    Console.Read();

            SystemMessaging.WelcomeMessage();

            Console.Write("User:  ");
            string user1 = Console.ReadLine();

            Console.Write("Password:  ");
            string password = Console.ReadLine();

            //verify user acc and password

        }
    }
}
