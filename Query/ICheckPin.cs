using ATM.Models;
using System.Collections.Generic;

namespace ATM
{
    public interface ICheckPin
    {
        List<UserModel> Run(string userName, string pin);
    }
}