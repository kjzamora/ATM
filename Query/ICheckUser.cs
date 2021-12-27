using ATM.Models;
using System.Collections.Generic;

namespace ATM
{
    public interface ICheckUser
    {
        List<UserModel> Run(string userName);
    }
}