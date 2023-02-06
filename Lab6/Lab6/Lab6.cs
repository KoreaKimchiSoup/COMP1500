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
            System.Console.WriteLine(column); // 6
            System.Console.WriteLine(row);      // 5

            int[,] arrayCopy = new int[row, column];

            for (int i = 0; i < column; i++) 
            {
                for (int j = 0; j < row; j++)
                {
                    arrayCopy[i, j] = array[i - i, i];
                    //            6  5             5  6            
                }
            }

            System.Console.WriteLine();
            /*
                {  1,  2,  3,  4,  5,  6 },
                { 11, 12, 13, 14, 15, 16 },
                { 21, 22, 23, 24, 25, 26 },
                { 31, 32, 33, 34, 35, 36 },
                { 41, 42, 43, 44, 45, 46 }
             * 
            /*
                41   31   21   11   1
                42   32   22   12   2
                43   33   23   13   3
                44   34   24   14   4
                45   35   25   15   5
                46   36   26   16   6
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
            */


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write("{0, -10}", arrayCopy[i, j]);
                }
                System.Console.WriteLine();
            }

            return arrayCopy;
        }
    }
}