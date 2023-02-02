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
                double r = 0.0;
                if (u <= 10)
                {
                    r = u / 2.0;
                    Console.WriteLine(r);
                }
                else if (u <= 100)
                {
                    r = ((16 * u) / 5.0) - 27;
                    Console.WriteLine(r);
                }
                else if (u <= 1000)
                {
                    r = Math.Pow(u, 2) / 4.0 - (2 * u) - 2007;
                    Console.WriteLine(r);
                }
                else if (u > 1000)
                {
                    r = 245743 + u / 4.0;
                    Console.WriteLine(r);
                }

                if (revenuePerDay[i] != r)
                {
                    bFixed = true;
                    revenuePerDay[i] = r;
                }

                if (revenuePerDay.Length != usersPerDay.Length)
                {
                   return false;
                }
            }

            return bFixed;
        }


        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            int invalidCount = 0;
            for (int i = 0; i < usersPerDay.Length; i++)
            {
                uint u = usersPerDay[i];
                double r = 0;
                if (u <= 10)
                {
                    r = u / 2.0;
                }
                else if (u <= 100)
                {
                    r = ((16 * u) / 5.0) - 27;
                }
                else if (u <= 1000)
                {
                    r = Math.Pow(u, 2) / 4.0 - (2 * u) - 2007;
                }
                else if (u > 1000)
                {
                    r = 245743 + u / 4.0;
                }
                else if(revenuePerDay[i] != r)
                {
                    invalidCount++;
                }
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
