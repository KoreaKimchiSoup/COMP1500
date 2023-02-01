using System;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] revenuePerDay = new double[7] { 1.50, 5.00, 184.20, 341.00, 104591.00, 246001.00, 246873.00 };

            double totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 0, 4); // 105122.7
            Console.WriteLine(totalRevenue);
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 5, 5); // 246001
            Console.WriteLine(totalRevenue);
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 4, 6); // 597465
            Console.WriteLine(totalRevenue);
        }
    }
}
