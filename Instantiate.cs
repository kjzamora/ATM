using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    // Dedicated class to object instantiation
    public static class Instantiate
    {
        public static IDataAccess CreateDataAccess()
        {
            return new DataAccess();
        }
    }
}
