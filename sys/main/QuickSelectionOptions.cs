namespace ATM
{
    public class QuickSelectionOptions
    {
        public static int Amount(int mainMenuOption)
        {
            int amount = 0;
            switch (mainMenuOption)
            {

                case 1:
                    amount = 20;
                    break;
                case 2:
                    amount = 40;
                    break;
                case 3:
                    amount = 60;
                    break;
                case 4:
                    amount = 80;
                    break;
                case 5:
                    amount = 100;
                    break;
            }
            return amount;
        }
    }
}