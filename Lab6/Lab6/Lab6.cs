using System.Data.Common;

namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int[,] arrayCopy = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayCopy[j, rows - i - 1] = array[i, j];
                }
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

            else if (mode == EMode.VerticalMirror)
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
                /*
                 {  1,  2,  3,  4,  5,  6 },
                { 11, 12, 13, 14, 15, 16 },
                { 21, 22, 23, 24, 25, 26 },
                { 31, 32, 33, 34, 35, 36 },
                { 41, 42, 43, 44, 45, 46 }

                46   41   42   43   44   45
                6     1     2    3     4     5
                16   11   12   13   14   15
                26   21   22   23   24   25
                36   31   32   33   34   35
                */
            }
        }
    }
}