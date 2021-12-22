using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class MainMenu
    {
        public static void Selection(int selection)
        {
            switch (selection)
            {
                case 1:
                    WithdrawMenuOptionsMessaging.WithdrawOptions();
                    break;
            }
        }
    }
}
