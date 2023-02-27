using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] array = new uint[0];
            bool bPass = Lab7.PlayGame(array); // false

            array = new uint[3] { 2, 2, 0 };
            bPass = Lab7.PlayGame(array); // true
        }
    }
}
