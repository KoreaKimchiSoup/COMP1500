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

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    canvas[i, j] = '*';
                }
            }

            if (shape == EShape.Rectangle)
            {//123
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (i == 0 || i == height - 1)
                        {
                            canvas[i, j] = '-';
                        }
                        else if (j == 0 || j == width - 1)
                        {
                            canvas[i, j] = '|';
                        }
                    }
                }
            }

            return canvas;
        }
    }
}
