using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            double[] revenuePerDayCopy = new double[revenuePerDay.Length];
            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                revenuePerDayCopy[i] = revenuePerDay[i];
            }

            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                Console.WriteLine(revenuePerDayCopy[i]);
            }
            
            return false;
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
