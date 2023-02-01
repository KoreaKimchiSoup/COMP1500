namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {//                                  일일 사용자           일일 매출
            /*
               R = u / 2                  0 <= u <= 10인 경우
               R = 16 * u / 5 - 27        10 < u <= 100인 경우
               R = u^2 / 4 - 2*u - 2007   100 < u <= 1000인 경우
               R = 245743 + u / 4         u > 1000인 경우

               R은 매출 u는 사용자 수를 의미
             */

            return false;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            int invalidEntryCount = 0;
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }

            for (int i = 0; i < usersPerDay.Length; i++)
            {
                if (usersPerDay[i] != revenuePerDay[i])
                {
                    invalidEntryCount++;
                }
            }
            return invalidEntryCount;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            double dNum = 0;

            if (start > revenuePerDay.Length)
            {// 시작, index가 매출 데이터 수보다 이상일 때
                return -1;
            }

            if (end > revenuePerDay.Length)
            {// 끝 index가 매출 데이터 수보다 이상일 때

                return -1;
            }

            if (start > end)
            {
                return -1;
            }

            if (revenuePerDay.Length == 0)
            {// 매출 데이터(요소) 수가 0일 때
                return -1;
            }

            if (start <= end)
            {// 시작 색인이 끝 색인보다 이하일 때
                for (uint i = start; i <= end; i++)
                {
                    dNum += revenuePerDay[i];
                }
            }
            
            return dNum;
        }
    }
}
