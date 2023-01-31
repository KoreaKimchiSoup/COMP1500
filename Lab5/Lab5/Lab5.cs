namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {//                                  일일 사용자           일일 매출            
            return false;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            return -1;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            if (revenuePerDay.Length < start)
            {
                return -1;
            }
            else if (end < start)
            {
                return -1;
            }
            else if (revenuePerDay.Length <= 0)
            {
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
