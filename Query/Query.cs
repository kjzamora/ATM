using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class Query
    {
        public static string VerifyUser(string userName)
        {
            return $"select username from tbluseraccount where username='{ userName }'";
        }
        public static string VerifyPin(string userName, string pin)
        {
            return $"select pin from tbluseraccount where username='{ userName }' and pin='{ pin }'";
        }
        public static string UserData(string userName, string pin)
        {
            return $"select * from tbluseraccount where username='{ userName }' and pin='{ pin }'";
        }
    }
}
