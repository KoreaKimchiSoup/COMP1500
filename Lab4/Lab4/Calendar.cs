namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year % 4 == 0 && year % 100 == 0 || year % 400 == 0)
            {
                return true;
            }
            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            return -1;
        }
    }
}













