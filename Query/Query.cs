﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class Query
    {
        public static string CheckUser(string userName)
        {
            return $"select username from tbluseraccount where username='{ userName }'";
        }
        public static string CheckPin(string userName, string pin)
        {
            return $"select pin from tbluseraccount where username='{ userName }' and pin='{ pin }'";
        }
        public static string UserData(string userName, string pin)
        {
            return $"select * from tbluseraccount where username='{ userName }' and pin='{ pin }'";
        }
        public static string UpdateBalance(string userName, string pin, string balance)
        {
            return $"update tbluseraccount set balance='{ balance }' where username='{ userName }' and pin='{ pin }'";
        }
    }
}
