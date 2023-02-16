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

            for (uint i = 0; i < height + 4; i++)
            {
                for (uint j = 0; j < width + 4; j++)
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

            switch (shape)
            {
                case EShape.Rectangle:
                    for (uint i = 1; i < height + 1; i++)
                    {
                        for (uint j = 1; j < width + 1; j++)
                        {
                            canvas[i + 1, j + 1] = '*';
                        }
                    }
                    break;

                case EShape.IsoscelesRightTriangle:
                    if (width != height)
                    {
                        return new char[0, 0];
                    }

                    for (uint i = 2; i < height + 2; i++)
                    {
                        for (uint j = 2; j < i + 1; j++)
                        {
                            canvas[i, j] = '*';
                        }
                    }
                    break;

                case EShape.IsoscelesTriangle:
                    if (width != height * 2 - 1)
                    {
                        return new char[0, 0];
                    }

                    for (uint i = 0; i < height; i++)
                    {
                        for (uint j = 0; j < width; j++)
                        {
                            if (j >= height - i - 1 && j <= height + i - 1)
                            {
                                canvas[i + 2, j + 2] = '*';
                            }
                        }
                    }
                    break;

                case EShape.Circle:
                    if (width != height)
                    {
                        return new char[0, 0];
                    }

                    if (width % 2 == 0)
                    {
                        return new char[0, 0];
                    }

                    uint centerX = width / 2; // 원의 중앙 좌표 x값
                    uint centerY = height / 2; // 원의 중앙 좌표 y값
                    uint radius = width / 2;     // 반지름

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            long distanceFromCenterX = j - centerX; // 중앙 으로부터의 x값 좌표
                            long distanceFromCenterY = i - centerY; // 중앙 으로부터의 y값 좌표
                            if (distanceFromCenterX * distanceFromCenterX +
                                distanceFromCenterY * distanceFromCenterY <= radius * radius)
                            {
                                canvas[i + 2, j + 2] = '*';
                                // + 2 씩 더해주는건 외곽선의 안으로 보정시키는 용도
                            }
                        }
                    }
                    break;
            }

            return canvas;
        }

        public static bool IsShape(char[,] canvas, EShape shape)
        {
            uint width = (uint)canvas.GetLength(1);
            uint height = (uint)canvas.GetLength(0);

            if (width == 0 || height == 0)
            {
                return false;
            }

            char[,] expected = Draw(width, height, shape);

            if (width != expected.GetLength(1) || height != expected.GetLength(0))
            {
                return false;
            }

            for (int i = 2; i < height + 2; i++)
            {
                for (int j = 2; j < width + 2; j++)
                {
                    if (canvas[i, j] != expected[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
