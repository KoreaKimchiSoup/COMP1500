using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] canvas = Canvas.Draw(15, 12, EShape.Rectangle);
            printCanvas(canvas);
        }

        private static void printCanvas(char[,] canvas)
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.Write(canvas[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
