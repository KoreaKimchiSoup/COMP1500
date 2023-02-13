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

            char[,] canvas = new char[height + 4, width + 4];

            for (int i = 0; i < height + 4; i++)
            {
                for (int j = 0; j < width + 4; j++)
                {
                    if (i == 0 || i == height + 3)
                    {
                        canvas[i, j] = '-';
                    }

                    else if (j == 0 || j == width + 3)
                    {
                        canvas[i, j] = '|';
                    }

                    else
                    {
                        canvas[i, j] = ' ';
                    }
                }
            }

            switch(shape)
            {
                case EShape.Rectangle:
                    for (int i = 1; i < height + 1; i++)
                    {
                        for (int j = 1; j < width + 1; j++)
                        {
                            canvas[i + 1, j + 1] = '*';
                        }
                    }
                    break;

                case EShape.IsoscelesRightTriangle:
                    if (width != height)
                    {
                        return canvas = new char[0, 0];
                    }
                    break;
            }

            return canvas;
        }
        
        public static bool IsShape(char[,] canvas, EShape shape)
        {

            return false;
        }
        
    }
}
