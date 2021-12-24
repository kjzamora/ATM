using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class MySQLConnection : IMySQLConnection
    {
        public string Connection()
        {
            return @"server=localhost; database=usersdb; user id=DBAdmin; password=admin;";
        }
    }
}
