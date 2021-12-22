using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class UserOptions
    {
        public static string UpdateBalance(string userName, string pin, string balance)
        {
            return $"update tbluseraccount set balance='{ balance }' where username='{ userName }' and pin='{ pin }'";
        }
    }
}
