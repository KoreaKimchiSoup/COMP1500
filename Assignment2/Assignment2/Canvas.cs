using System;

namespace Assignment2
{
    public static class Canvas
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            char[,] canvas = new char[height, width];

            switch (shape)
            {
                case EShape.Rectangle:
                    if (width == 0 && height == 0)
                    {
                        return new char[0, 0];
                    }

                    for (int i = 0; i < canvas.GetLength(0); i++)
                    {
                        for (int j = 0; j < canvas.GetLength(1); j++)
                        {
                            if (i == 0 || i == canvas.GetLength(0) - 1) // 0 or 4
                            {
                                canvas[i, j] = '-';
                            }
                            else if (j == 0 || j == canvas.GetLength(1) - 1) // 0 or 5
                            {
                                canvas[i, j] = '|';
                            }
                            else if (shape == EShape.Rectangle)
                            {
                                canvas[i, j] = '*';
                            }
                        }
                    }

                    for (int i = 1; i < canvas.GetLength(1) - 1; i++)
                    {
                        canvas[1, i] = ' ';
                    }

                    for (int i = 1; i < canvas.GetLength(1) - 1; i++)
                    {
                        canvas[canvas.GetLength(0) - 2, i] = ' ';
                    }
                    break;

                case EShape.IsoscelesRightTriangle:
                    // 코딩
                    break;

                case EShape.IsoscelesTriangle:
                    // 코딩
                    break;

                case EShape.Circle:
                    // 코딩
                    break;
            }
            return canvas;
        }
    }
}
