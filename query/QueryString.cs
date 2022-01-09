namespace ATM
{
    public class QueryString : IQueryString
    {
        public string CheckUser(string userName)
        {
            return $"select username from tbluseraccount where username='{ userName }'";
        }
        public string CheckPin(string userName, string pin)
        {
            return $"select pin from tbluseraccount where username='{ userName }' and pin='{ pin }'";
        }
        public string UserData(string userName, string pin)
        {
            return $"select * from tbluseraccount where username='{ userName }' and pin='{ pin }'";
        }
        public string UpdateBalance(string userName, string pin, string balance)
        {
            return $"update tbluseraccount set balance='{ balance }' where username='{ userName }' and pin='{ pin }'";
        }
    }
}
