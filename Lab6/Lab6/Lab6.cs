
namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] data)
        {
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);
            int[,] arrayCopy = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayCopy[j, rows - i - 1] = data[i, j];
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
                //asdasdasd
            }
        }
    }
}