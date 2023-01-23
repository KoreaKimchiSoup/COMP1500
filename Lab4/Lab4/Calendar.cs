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
            else if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else if(year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                return true;
            }
            else if(year % 4 != 0 && year % 100 != 0 && year % 400 != 0)
            {
                return false;
            }
            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year > 9999 && month >= 13)
            {
                return -1;
            }
            // 31일인 달: 1, 3, 5, 7, 8, 10, 12
            // 30일인 달: 4, 6, 9, 11
            // 2월달이 윤년인지 평년인지 (28 or 29)

            if (month <= 7 && month % 2 == 1) // 1 ~ 7
            {
                return 31;
            }
            else if (month >= 8 && month % 2 == 0) // 8 ~ 12
            {
                return 31;
            }            
            else
            {
                return 30;
            }

            if (month == 2)
            {
                if (year % 4 == 0 && year % 100 == 0 && year % 400 != 0)
                {
                    return 28;
                }
                else if (year % 4 == 0 && year % 100 != 0)
                {
                    return 29;
                }
                else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                {
                    return 29;
                }
                else if (year % 4 != 0 && year % 100 != 0 && year % 400 != 0)
                {
                    return 28;
                }
            }
        }
    }
}













