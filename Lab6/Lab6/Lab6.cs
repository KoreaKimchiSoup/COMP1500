using System;

namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] array)
        {
            // ROW = 행(가로 x), COLUMN = 열(세로 y)
            // 2차원 배열을 90도 회전했을 때 x의 값이 6 이므로 기존의
            // 2차원 배열과 다른 x, y값을 가짐
            // 즉, [5, 6] - > [6, 5] (열 + 1) (행 - 1)

            int column = array.GetLength(1); // colunm에 행(6)값 가져옴
            int row = array.GetLength(0); // row에 열(5)값 가져옴
            // System.Console.WriteLine(column); // 6
            // System.Console.WriteLine(row);      // 5

            int[,] result = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    int shiftedRow = (i + j + 1) % row;
                    int shiftedColumn = (j + 1) % column;
                    result[shiftedRow, shiftedColumn] = array[i, j];
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0, -10}", result[i, j]);
                }
                Console.WriteLine();
            }

            return result;
        }
        /*
                        1     2    3    4    5    6
                        11   12   13   14   15   16
                        21   22   23   24   25   26
                        31   32   33   34   35   36
                        41   42   43   44   45   46                            

                        46   41   42   43   44   45
                        6     1    2    3    4    5
                        16   11   12   13   14   15
                        26   21   22   23   24   25
                        36   31   32   33   34   35








        /*
        ---------------------------------------------------------------EMode.HorizontalMirror
        int[,] arrayCopy = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arrayCopy[i, j] = array[i, column - 1 - j];
                System.Console.Write("{0, -10}", arrayCopy[i, j]);
            }
            System.Console.WriteLine();
        }

        6     5     4     3    2     1
        16   15   14   13   12   11
        26   25   24   23   22   21
        36   35   34   33   32   31
        46   45   44   43   42   41            
        /*
        -----------------------------------------------------------------------------------------------Rotate90Degrees
        int column = array.GetLength(1); // colunm에 행(6)값 가져옴
        int row = array.GetLength(0); // row에 열(5)값 가져옴
        // System.Console.WriteLine(column); // 6
        // System.Console.WriteLine(row);      // 5

        int[,] arrayCopy = new int[column, row];

        for (int i = 0; i < column; i++) 
        {
            for (int j = 0; j < row; j++)
            {
                arrayCopy[i, j] = array[row - 1 - j, i];
                System.Console.Write("{0, -10}", arrayCopy[i, j]);
            }
            System.Console.WriteLine();
        }

        -----------------------------------------------------------------------------------------------EMode.VerticalMirror 
        int column = array.GetLength(1); // colunm에 행(6)값 가져옴
        int row = array.GetLength(0); // row에 열(5)값 가져옴
        System.Console.WriteLine(column); // 6
        System.Console.WriteLine(row);      // 5

        int[,] arrayCopy = new int[row, column];

        for (int i = 0; i < row; i++) 
        {
            for (int j = 0; j < column; j++)
            {
                arrayCopy[i, j] = array[row - 1 - i, j];
            }
        }
        -----------------------------------------------------------------------------------------------


        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
               // System.Console.Write("{0, -10}", arrayCopy[i, j]);
            }
            System.Console.WriteLine();
        }

        return arrayCopy;
        */
    }
}