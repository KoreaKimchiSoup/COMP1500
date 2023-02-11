using System.Data.Common;

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
            int column = array.GetLength(1);
            int row = array.GetLength(0);

            if (mode == EMode.HorizontalMirror)
            {
                
            }
            else if (mode == EMode.VerticalMirror)
            {

            }
            else if (mode == EMode.DiagonalShift)
            {

            }
        }
    }
}