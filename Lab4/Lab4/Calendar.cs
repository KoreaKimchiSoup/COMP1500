namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {

            /*  
                기본 조건: 4로 나눠 떨어지면 윤년이다.
                예외: 단 1의 기본 조건을 만족해도 100으로 나눠 떨어질 경우는 윤년이 아니다.
                예외의 예외: 단 2의 예외에 포함되어도 400으로 나눠 떨어지면 여전히 윤년이다.
             */
            
            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            return -1;
        }
    }
}