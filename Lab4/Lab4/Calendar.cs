namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year % 4 == 0 && year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }

            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                return true;
            }

            if (year % 4 != 0 && year % 100 != 0 && year % 400 != 0)
            {
                return false;
            }
            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year < 9999 && month < 13)
            {
                //for (int i = 1; year )
            }    
            return -1;
        }
    }
}













