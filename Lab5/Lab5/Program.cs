using System;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] revenuePerDay = new double[-1];

            double totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 0, 4); // 105122.7
            Console.WriteLine(totalRevenue);
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 5, 5); // 246001
            Console.WriteLine(totalRevenue);
            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 4, 6); // 597465
            Console.WriteLine(totalRevenue);
        }
    }
}