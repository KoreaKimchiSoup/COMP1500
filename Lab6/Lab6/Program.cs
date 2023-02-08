using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[5, 6]
            {
                {  1,  2,  3,  4,  5,  6 },
                { 11, 12, 13, 14, 15, 16 },
                { 21, 22, 23, 24, 25, 26 },
                { 31, 32, 33, 34, 35, 36 },
                { 41, 42, 43, 44, 45, 46 }
            };

            int[,] rotated = Lab6.Rotate90Degrees(data);
            /*
            41   31   21   11   1
            42   32   22   12   2
            43   33   23   13   3
            44   34   24   14   4
            45   35   25   15   5
            46   36   26   16   6
            */
        }
    }
}
