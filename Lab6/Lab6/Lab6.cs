using System;

namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] array)
        {
            int columnCount = array.GetLength(1);
            int rowCount = array.GetLength(0);

            int[,] arrayCopy = new int[columnCount, rowCount];

            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    arrayCopy[i, j] = array[rowCount - 1 - j, i];
                    Console.Write("{0, -10}", arrayCopy[i, j]);
                }
                Console.WriteLine();
            }

            return arrayCopy;
        }

        public static void TransformArray(int[,] array, EMode mode)
        {
            if (mode == EMode.HorizontalMirror)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1) / 2; j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, array.GetLength(1) - j - 1];
                        array[i, array.GetLength(1) - j - 1] = temp;
                    }
                }
            }

            if (mode == EMode.VerticalMirror)
            {
                for (int i = 0; i < array.GetLength(0) / 2; i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[array.GetLength(0) - i - 1, j];
                        array[array.GetLength(0) - i - 1, j] = temp;
                    }
                }
            }

            else if (mode == EMode.DiagonalShift)
            {// asd
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                for (int i = 0; i < rows / 2; i++)
                {
                    for (int j = i; j < cols - i - 1; j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[rows - j - 1, cols - i - 1];
                        array[rows - j - 1, cols - i - 1] = array[rows - i - 1, j];
                        array[rows - i - 1, j] = array[j, i];
                        array[j, i] = temp;
                    }
                }
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