namespace ATM
{
    public class MySQLConnection : IMySQLConnection
    {
        public string Connection()
        {
            return @"server=localhost; database=usersdb; user id=root; password=SQLpass;";
        }
    }
}
