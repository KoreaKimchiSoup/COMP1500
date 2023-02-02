using System;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] usersPerDay = new uint[7] { 3, 10, 66, 101, 657, 1032, 4520 };
            double[] revenuePerDay = new double[7] { 1.50, 5.00, 184.20, 341.25, 104591.25, 246001.00, 246873.00 };

            int numInvalidEntries = Lab5.GetInvalidEntryCount(usersPerDay, revenuePerDay); // 0
            Console.WriteLine(numInvalidEntries);

            usersPerDay = new uint[7] { 3, 10, 66, 101, 657, 1032, 4520 };
            revenuePerDay = new double[8] { 1.50, 5.00, 200.00, 341.25, 435.44, 246001.00, 22.22, 1.0 };

            numInvalidEntries = Lab5.GetInvalidEntryCount(usersPerDay, revenuePerDay); // 3
            Console.WriteLine(numInvalidEntries);
        }
    }
}