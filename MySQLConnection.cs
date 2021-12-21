using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class MySQLConnection
    {
        public static string Connection()
        {
            return @"server=localhost; database=usersdb; user id=DBAdmin; password=admin;";
        }
    }
}
