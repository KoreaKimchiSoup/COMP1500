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
                }
                System.Console.WriteLine();
            }

            return arrayCopy;
        }

        public static void TransformArray(int[,] array, EMode eMode)
        {
            EMode mode = EMode.HorizontalMirror;
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

            {
                int rowCount = array.GetLength(0);
                int colCount = array.GetLength(1);

                if (mode == EMode.DiagonalShift)
                {
                    int temp = array[rowCount - 1, colCount - 1];
                    for (int i = rowCount - 1; i > 0; i--)
                    {
                        array[i, colCount - 1] = array[i - 1, colCount - 1];
                    }
                    for (int j = colCount - 1; j > 0; j--)
                    {
                        array[0, j] = array[0, j - 1];
                    }
                    for (int i = 0; i < rowCount - 1; i++)
                    {
                        array[i, 0] = array[i + 1, 0];
                    }
                    for (int j = 0; j < colCount - 1; j++)
                    {
                        array[rowCount - 1, j] = array[rowCount - 1, j + 1];
                    }
                    array[1, colCount - 1] = temp;
                }
            }
        }
    }
}