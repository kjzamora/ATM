namespace ATM
{
    public interface IQueryString
    {
        string CheckPin(string userName, string pin);
        string CheckUser(string userName);
        string UpdateBalance(string userName, string pin, string balance);
        string UserData(string userName, string pin);
    }
}