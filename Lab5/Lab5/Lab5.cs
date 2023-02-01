using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {//                                  일일 사용자           일일 매출
            bool bFixed = false;
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return false;
            }

            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                if (double.IsNaN(revenuePerDay[i]))
                {
                    revenuePerDay[i] = usersPerDay[i];
                    bFixed = true;
                }
            }

            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                if (usersPerDay[i] >= 0 && usersPerDay[i] <= 10)
                {
                    revenuePerDay[i] = usersPerDay[i] / 2.0;
                    revenuePerDay[i] = Math.Round(revenuePerDay[i], 2);
                }
                else if (usersPerDay[i] > 10 && usersPerDay[i] <= 100)
                {
                    revenuePerDay[i] = 16 * usersPerDay[i] / 5.0 - 27;
                    revenuePerDay[i] = Math.Round(revenuePerDay[i], 2);
                }
                else if (usersPerDay[i] > 100 && usersPerDay[i] <= 1000)
                {
                    revenuePerDay[i] = usersPerDay[i] ^ 2 / 4 - 2 * usersPerDay[i] - 2007;
                    revenuePerDay[i] = Math.Round(revenuePerDay[i], 2);
                }
                else if (usersPerDay[i] > 1000)
                {
                    revenuePerDay[i] = 245743 + usersPerDay[i] / 4.0;
                    revenuePerDay[i] = Math.Round(revenuePerDay[i], 2);
                }
            }

            return bFixed;
        }


        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            if (revenuePerDay.Length != usersPerDay.Length)
            {
                return -1;
            }

            int invalidEntryCount = 0;
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
            {// 시작, 혹은 끝 index가 매출 데이터 수보다 이상일 때
                return -1;
            }

            if (end > revenuePerDay.Length)
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
