using System;
using System.Diagnostics;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] canvas = new char[0, 0];

            canvas = Canvas.Draw(7, 7, EShape.Rectangle);
            printCanvas(canvas);
            

            // canvas를 콘솔 창에 출력해주는 도우미 함수
            static void printCanvas(char[,] canvas)
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
}
