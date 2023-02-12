using System;
using System.Diagnostics;

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

            Lab6.TransformArray(data, EMode.DiagonalShift);

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
                /*
                46   41   42   43   44   45
                6    1    2    3    4    5
                16   11   12   13   14   15
                26   21   22   23   24   25
                36   31   32   33   34   35
                */
            }
        }
    }
}