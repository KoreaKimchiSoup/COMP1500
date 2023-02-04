using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Check_GetInvalidEntryCount();
            Check_CalculateTotalRevenue();
        }

        /// <summary>
        /// 함수 "GetInvalidEntryCount()" 테스트 코드
        /// </summary>
        static void Check_GetInvalidEntryCount()
        {
            // 방문객 및 수익 배열 선언
            uint[] usersPerDay = new uint[20] { 0, 2, 3, 7, 10, 11, 23, 47, 66, 100, 101, 221, 341, 727, 1000, 1001, 1213, 1412, 2131, 2150 };
            double[] revenuePerDay = new double[20] { 0.00, 1.00, 1.50, 3.50, 5.00, 8.20, 46.60, 123.40, 184.20, 293.00, 341.25, 9761.25, 26381.25, 128671.25, 245993.00, 245993.25, 246046.25, 246096.00, 246275.75, 246280.50 };

            // 유효하지 않은 계산값이 0개인 경우
            int numInvalidEntries = Lab5.GetInvalidEntryCount(usersPerDay, revenuePerDay); // 0
            System.Console.WriteLine(numInvalidEntries);

            // 유효하지 않은 계산값이 2개인 경우
            revenuePerDay[10] = 100.00;
            revenuePerDay[15] = 200.00;
            numInvalidEntries = Lab5.GetInvalidEntryCount(usersPerDay, revenuePerDay); // 2
            System.Console.WriteLine(numInvalidEntries);

            // 유효하지 않은 계산값이 4개인 경우
            revenuePerDay[10] = 100.00;
            revenuePerDay[15] = 200.00;
            revenuePerDay[18] = 300.00;
            revenuePerDay[19] = 400.00;
            numInvalidEntries = Lab5.GetInvalidEntryCount(usersPerDay, revenuePerDay); // 4
            System.Console.WriteLine(numInvalidEntries);
        }




        /// <summary>
        /// 함수 "CalculateTotalRevenue()" 테스트 코드
        /// </summary>
        static void Check_CalculateTotalRevenue()
        {
            // revenuePerDay 배열의 길이가 0인 경우
            double[] revenuePerDay = new double[0];
            double totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 0, 4); // -1
            System.Console.WriteLine(totalRevenue);

            // 종료 index가 시작 index보다 작은 경우
            revenuePerDay = new double[10] { 0.00, 46.60, 123.40, 184.20, 245993.00, 245993.25, 246046.25, 246096.00, 246275.75, 246280.50 };
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 4, 2); // -1
            System.Console.WriteLine(totalRevenue);

            // 시작 index가 revenuePerDay 배열의 길이보다 큰 경우
            revenuePerDay = new double[10] { 0.00, 46.60, 123.40, 184.20, 245993.00, 245993.25, 246046.25, 246096.00, 246275.75, 246280.50 };
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 10, 10); // -1
            System.Console.WriteLine(totalRevenue);

            // 종료 index가 revenuePerDay 배열의 길이보다 큰 경우
            revenuePerDay = new double[10] { 0.00, 46.60, 123.40, 184.20, 245993.00, 245993.25, 246046.25, 246096.00, 246275.75, 246280.50 };
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 0, 10); // -1
            System.Console.WriteLine(totalRevenue);

            // 정상 작동 코드
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 0, 2); // 170
            System.Console.WriteLine(totalRevenue);

            // 정상 작동 코드
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 4, 6); // 738032.5
            System.Console.WriteLine(totalRevenue);
        }
    }
}
