using System;

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
