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
            /*
            canvas와 똑같은 행/열 길이를 가진 newCanvas를 만든다.
            shape 인자를 파악해서 newCanvas에 shape에 맞는 도형을 그린다.
            canvas와 newCanvas 비교를 통해 return
            */
            uint newWidth = (uint)canvas.GetLength(0);
            uint newHeight = (uint)canvas.GetLength(1);
            
            if (newWidth == 0 || newHeight == 0)
            {
                return false;
            }

            char[,] newCanvas = new char[newHeight + 4, newWidth + 4];

            for (int i = 0; i < newHeight + 4; i++)
            {
                for (int j = 0; j < newWidth + 4; j++)
                {
                    if (i == 0 || i == newHeight + 3)
                    {
                        newCanvas[i, j] = '-';
                    }

                    else if (j == 0 || j == newWidth + 3)
                    {
                        newCanvas[i, j] = '|';
                    }

                    else
                    {
                        newCanvas[i, j] = ' ';
                    }
                }
            }

            switch (shape)
            {
                case EShape.Rectangle:
                    for (int i = 1; i < newHeight + 1; i++)
                    {
                        for (int j = 1; j < newWidth + 1; j++)
                        {
                            newCanvas[i + 1, j + 1] = '*';
                            if (canvas[i, j] != newCanvas[i, j])
                            {
                                return false;
                            }
                        }
                    }
                    return true;

                case EShape.IsoscelesRightTriangle:
                    if (newWidth != newHeight)
                    {
                        return false;
                    }

                    for (int i = 2; i < newHeight + 2; i++)
                    {
                        for (int j = 2; j < i + 1; j++)
                        {
                            newCanvas[i, j] = '*';
                            if (canvas[i, j] != newCanvas[i, j])
                            {
                                return false;
                            }
                        }
                    }
                    return true;

                case EShape.IsoscelesTriangle:
                    if (newWidth != newHeight * 2 - 1)
                    {
                        return false;
                    }

                    for (int i = 0; i < newHeight; i++)
                    {
                        for (int j = 0; j < newWidth; j++)
                        {
                            if (j >= newHeight - i - 1 && j <= newHeight + i - 1)
                            {
                                newCanvas[i + 2, j + 2] = '*';
                            }

                            if (canvas[i, j] != newCanvas[i, j])
                            {
                                return false;
                            }
                        }
                    }

                    break;

                case EShape.Circle:
                    if (newWidth != newHeight)
                    {
                        return false;
                    }

                    if (newWidth % 2 == 0)
                    {
                        return false;
                    }

                    uint centerX = newWidth / 2; // 원의 중앙 좌표 x값
                    uint centerY = newHeight / 2; // 원의 중앙 좌표 y값
                    uint radius = newWidth / 2;     // 반지름

                    for (int i = 0; i < newHeight; i++)
                    {
                        for (int j = 0; j < newWidth; j++)
                        {
                            long distanceFromCenterX = j - centerX; // 중앙 으로부터의 x값 좌표
                            long distanceFromCenterY = i - centerY; // 중앙 으로부터의 y값 좌표
                            if (distanceFromCenterX * distanceFromCenterX +
                                distanceFromCenterY * distanceFromCenterY <= radius * radius)
                            {
                                canvas[i , j] = '*';
                                // + 2 씩 더해주는건 외곽선의 안으로 보정시키는 용도
                            }
                        }
                    }

                    break;
            }

            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    if (canvas[i, j] != newCanvas[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
