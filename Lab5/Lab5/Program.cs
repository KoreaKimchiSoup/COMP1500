using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] usersPerDay = new uint[7] { 3, 10, 66, 101, 657, 1032, 4520 };
            double[] revenuePerDay = new double[7] { 1.50, 5.00, 184.20, 341.25, 104591.25, 246001.00, 246873.00 };

            bool bFixed = Lab5.TryFixData(usersPerDay, revenuePerDay); // revenuePerDay에 잘못된 요소값이 없으므로 false를 반환
            System.Console.WriteLine(bFixed);

            usersPerDay = new uint[7] { 3, 10, 66, 101, 657, 1032, 4520 };
            revenuePerDay = new double[7] { 1.50, 5.00, 200.00, 341.25, 435.44, 246001.00, 22.22 };

            bFixed = Lab5.TryFixData(usersPerDay, revenuePerDay); // true, revenuePerDay가 다음과 같이 고쳐짐 [ 1.50, 5.00, 184.20, 341.25, 104591.25, 246001.00, 246873.00 ]
            System.Console.WriteLine(bFixed);
        }
    }
}

