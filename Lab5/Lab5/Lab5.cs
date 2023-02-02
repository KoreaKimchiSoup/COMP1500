using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            bool bFixed = false;
            for (int i = 0; i < usersPerDay.Length; i++)
            {
                uint u = usersPerDay[i];
                double r;
                if (u <= 10)
                {
                    r = u / 2;
                }

                if (u <= 100)
                {
                    r = 16 * u / 5 - 27;
                }

                if (u <= 1000)
                {
                    r = u ^ 2 / 4 - 2 * u - 2007;
                }

                if (u > 1000)
                {
                    r = 245743 + u / 4;
                }
            }

            return bFixed;
        }


        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            int invalidCount = 0;

            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }

            return invalidCount;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            double dNum = 0;

            if (start < 0 || end >= revenuePerDay.Length || start > end)
            {// 시작, 혹은 끝 index가 매출 데이터 수보다 이상일 때
                return -1;
            }

            if (revenuePerDay.Length == 0)
            {// 매출 데이터(요소) 수가 0일 때
                return -1;
            }

            if (start > end)
            {
                return -1;
            }

            for (uint i = start; i <= end; i++)
            {
                dNum += revenuePerDay[i];
            }

            return dNum;
        }
    }    
}
