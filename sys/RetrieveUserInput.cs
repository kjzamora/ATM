using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class RetrieveUserInput : IRetrieveUserInput
    {
        public string Input()
        {
            return Console.ReadLine();
        }
    }
}
