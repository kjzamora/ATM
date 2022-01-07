using ATM.Models;
using System.Collections.Generic;

namespace ATM
{
    public interface IUpdateUserInfo
    {
        List<UserModel> Run(string userName, string pin, string balance);
    }
}