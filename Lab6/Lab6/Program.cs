using System;
using System.Diagnostics;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[1, 6]
            {
                {  1,  2,  3,  4,  5,  6 },
            };

            int[,] rotated = Lab6.Rotate90Degrees(data);

            // 출력
            for (int i = 0; i < rotated.GetLength(0); i++)
            {
                for (int j = 0; j < rotated.GetLength(1); j++)
                {
                    Console.Write(rotated[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}