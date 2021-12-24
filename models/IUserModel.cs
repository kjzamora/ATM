namespace ATM.Models
{
    public interface IUserModel
    {
        int Balance { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        int Pin { get; set; }
        string UserName { get; set; }
    }
}