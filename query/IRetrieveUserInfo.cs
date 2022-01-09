using ATM.Models;
using System.Collections.Generic;

namespace ATM
{
    public interface IRetrieveUserInfo
    {
        List<UserModel> Run(string userName, string pin);
    }
}