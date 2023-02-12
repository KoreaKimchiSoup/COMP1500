using System;

namespace Assignment2
{
    public static class Canvas
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            if (width == 0 || height == 0)
            {
                return new char[0, 0];
            }

            char[,] canvas = new char[height, width];
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    if (i == 0 || i == canvas.GetLength(0) - 1)
                    {
                        canvas[i, j] = '-';
                    }
                    else if (j == 0 || j == canvas.GetLength(1) - 1)
                    {
                        canvas[i, j] = '|';
                    }
                    else if (j == 0 || j == canvas.GetLength(1) - 1)
                    {
                        canvas[i, j] = ' ';
                    }
                    else if (shape == EShape.Rectangle)
                    {
                        canvas[i + 1, j] = '*';
                    }                    
                }
            }
            return canvas;
        }
    }
}
