namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] array)
        {
            int column = array.GetLength(1);
            int row = array.GetLength(0);

            int[,] arrayCopy = new int[column, row];

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    arrayCopy[i, j] = array[row - 1 - j, i];
                }
            }

            return arrayCopy;
        }

        public static void TransformArray(int[,] array, EMode.EModeA eModeA)
        {
            int column = array.GetLength(1);
            int row = array.GetLength(0);

            if (eModeA == EMode.EModeA.HorizontalMirror)
            {
                int[,] arrayCopy = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        arrayCopy[i, j] = array[i, column - 1 - j];
                    }
                }
            }
        }
        /*
        public static void TransformArray(int[,] array, EMode.EMOde eMOde)
        {
            int column = array.GetLength(1);
            int row = array.GetLength(0);

            int[,] arrayCopy = new int[row, column];

            if (eMOde == EMode.EMOde.VerticalMirror)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        arrayCopy[i, j] = array[row - 1 - i, j];
                    }
                }
            }
        }

        public static void TransformArrayDiagonalShift(int[,] array, EMode.EMOde eMOde)
        {
            int column = array.GetLength(1);
            int row = array.GetLength(0);

            int[,] arrayCopy = new int[row, column];

            if (eMOde == EMode.EMOde.DiagonalShift)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        int rowShift = (i + j + 1) % row;
                        int columnShift = (j + 1) % column;
                        //System.Console.Write($"rowShift: {rowShift}       ");
                        //System.Console.WriteLine($"columnShift: {columnShift}");
                        arrayCopy[rowShift, columnShift] = array[i, j];
                    }
                }

            }
            
            /*
                        1     2     3    4     5     6
                        11   12   13   14   15   16
                        21   22   23   24   25   26
                        31   32   33   34   35   36
                        41   42   43   44   45   46

                        46   41   42   43   44   45
                        6     1     2     3    4     5
                        16   11   12   13   14   15
                        26   21   22   23   24   25
                        36   31   32   33   34   35
        }
            */
    }
}