namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {//                                  일일 사용자           일일 매출            

            double[] revenuePerDayCopy = new double[revenuePerDay.Length];
            for (int i = 0; i < revenuePerDayCopy.Length; i++)
            {
                revenuePerDayCopy[i] = revenuePerDay[i];
            }

            for (int i = 0; i < revenuePerDayCopy.Length; i++)
            {
                if (revenuePerDay[i] != revenuePerDayCopy[i])
                {
                    revenuePerDay[i] = revenuePerDayCopy[i];
                    return true;
                }
            }
            return false;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }
            else if (usersPerDay.Length == 0 && revenuePerDay.Length == 0)
            {
                return -1;
            }

            int invalidIndex = 0;
            for (int i = 0; i < usersPerDay.Length; i++)
            {
                if (usersPerDay[i] != revenuePerDay[i])
                {
                    invalidIndex++;
                }
                return invalidIndex;
            }

            return -1;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            if (revenuePerDay.Length < start)
            {// 시작, 혹은 끝 index가 매출 데이터 수보다 이상일 때
                return -1;
            }
            else if (revenuePerDay.Length < end)
            {
                return -1;
            }
            else if (end < start)
            {// 시작 색인이 끝 색인보다 클 때
                return -1;
            }
            else if (revenuePerDay.Length <= 0)
            {// 매출 데이터(요소) 수가 0일 때
                return -1;
            }
            

            double dNum = 0;
            for (uint i = start; i <= end; i++)
            {
                dNum += revenuePerDay[i];
            }
            return dNum;
        }
    }
}
