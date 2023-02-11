using System;

namespace Lab6
{
    public static class Lab6
    {asd
        
        /*
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

        public static void TransformArray(int[,] array, EMode eMode)
        {
            EMode mode = EMode.None;
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
                        array[i, j] = array[array.GetLength(0) - i - 1, j]; // asda asd asd
                        array[array.GetLength(0) - i - 1, j] = temp;
                    }
                }
            }

            else if (mode == EMode.DiagonalShift)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = i; j < array.GetLength(1); j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;
                    }
                }
            }
        }
    }
}


            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    arrayCopy[i, j] = array[rowCount - 1 - j, i];
                }
            }
            */
    }
}