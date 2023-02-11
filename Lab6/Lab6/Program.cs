using System;
using System.Diagnostics;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] test1Row = { { 112, 113, 103, 108, 44, 57, 68, 32, 144, 98, 41, 76, 100, 147, 41, 9, 29, 142, 27 } };

            int[,] rotated = Lab6.Rotate90Degrees(test1Row);
            printArray(rotated);


            int[,] test1Col ={
                                { 27},
                                { 142} ,
                                { 29} ,
                                { 9} ,
                                { 41} ,
                                { 147} ,
                                { 100} ,
                                { 76} ,
                                { 41} ,
                                { 98} ,
                                { 144} ,
                                { 32} ,
                                { 68} ,
                                { 57 } ,
                                { 44 } ,
                                { 108} ,
                                { 103} ,
                                { 113} ,
                                { 112}
            };

            rotated = Lab6.Rotate90Degrees(test1Col);
            printArray(rotated);

            int[,] data = getTestArray();

            rotated = Lab6.Rotate90Degrees(data);
            printArray(rotated);

            Debug.Assert(isArrayEqual(new int[,]
            {
                { 41, 31, 21, 11, 1 },
                { 42, 32, 22, 12, 2 },
                { 43, 33, 23, 13, 3 },
                { 44, 34, 24, 14, 4 },
                { 45, 35, 25, 15, 5 },
                { 46, 36, 26, 16, 6 }
            }, rotated));


            int[,] test2Row = { { 112, 113, 103, 108, 44, 57, 68, 32, 144, 98, 41, 76, 100, 147, 41, 9, 29, 142, 27 } };

            Lab6.TransformArray(test2Row, EMode.HorizontalMirror);
            printArray(test2Row);

            int[,] test2Col ={
                    { 112 } ,
                    { 113 } ,
                    { 103 } ,
                    { 108 } ,
                    { 44  } ,
                    { 57  } ,
                    { 68  } ,
                    { 32  } ,
                    { 144 } ,
                    { 98  } ,
                    { 41  } ,
                    { 76  } ,
                    { 100 } ,
                    { 147 } ,
                    { 41  } ,
                    { 9   } ,
                    { 29  } ,
                    { 142 } ,
                    { 27  }
                };

            Lab6.TransformArray(test2Col, EMode.HorizontalMirror);
            printArray(test2Col);

            data = getTestArray();

            Lab6.TransformArray(data, EMode.HorizontalMirror);
            printArray(data);

            Debug.Assert(isArrayEqual(new int[,]
            {
                { 6, 5, 4, 3, 2, 1 },
                { 16, 15, 14, 13, 12, 11 },
                { 26, 25, 24, 23, 22, 21 },
                { 36, 35, 34, 33, 32, 31 },
                { 46, 45, 44, 43, 42, 41 }
            }, data));

            int[,] testMn =
            {
                {   113 ,   103 ,   108 ,   44  ,   57  ,   68  ,   32  ,   144 ,   98  ,   41  ,   76  ,   100 ,   147 ,   41  ,   9   }   ,
                {   29  ,   142 ,   27  ,   21  ,   45  ,   102 ,   78  ,   101 ,   143 ,   79  ,   132 ,   46  ,   20  ,   131 ,   13  }   ,
                {   47  ,   35  ,   20  ,   29  ,   47  ,   29  ,   8   ,   95  ,   27  ,   74  ,   126 ,   60  ,   26  ,   90  ,   110 }   ,
                {   92  ,   18  ,   81  ,   85  ,   33  ,   133 ,   78  ,   29  ,   97  ,   10  ,   34  ,   1   ,   114 ,   114 ,   75  }   ,
                {   22  ,   12  ,   12  ,   85  ,   143 ,   40  ,   80  ,   117 ,   144 ,   130 ,   20  ,   46  ,   0   ,   97  ,   69  }   ,
                {   41  ,   51  ,   11  ,   32  ,   137 ,   113 ,   114 ,   84  ,   97  ,   29  ,   118 ,   6   ,   72  ,   19  ,   12  }   ,
                {   27  ,   43  ,   130 ,   101 ,   51  ,   114 ,   48  ,   91  ,   96  ,   70  ,   11  ,   50  ,   87  ,   105 ,   12  }   ,
                {   86  ,   78  ,   81  ,   28  ,   118 ,   132 ,   140 ,   81  ,   127 ,   111 ,   57  ,   77  ,   64  ,   55  ,   24  }   ,
                {   33  ,   7   ,   98  ,   131 ,   102 ,   127 ,   66  ,   48  ,   46  ,   105 ,   143 ,   110 ,   65  ,   112 ,   126 }   ,
                {   63  ,   27  ,   129 ,   85  ,   93  ,   40  ,   74  ,   44  ,   50  ,   29  ,   37  ,   112 ,   3   ,   140 ,   143 }   ,
                {   36  ,   134 ,   35  ,   72  ,   36  ,   3   ,   101 ,   105 ,   2   ,   35  ,   19  ,   29  ,   35  ,   73  ,   125 }   ,
                {   21  ,   75  ,   119 ,   1   ,   48  ,   29  ,   98  ,   129 ,   112 ,   133 ,   109 ,   113 ,   48  ,   102 ,   65  }   ,
                {   14  ,   63  ,   58  ,   52  ,   68  ,   9   ,   75  ,   142 ,   75  ,   122 ,   111 ,   72  ,   126 ,   49  ,   73  }   ,
                {   11  ,   38  ,   121 ,   74  ,   7   ,   112 ,   142 ,   2   ,   92  ,   114 ,   88  ,   4   ,   73  ,   88  ,   77  }   ,
                {   40  ,   53  ,   2   ,   86  ,   21  ,   106 ,   120 ,   133 ,   4   ,   116 ,   96  ,   82  ,   44  ,   28  ,   86  }   ,
                {   107 ,   121 ,   80  ,   38  ,   121 ,   70  ,   141 ,   124 ,   94  ,   103 ,   21  ,   61  ,   116 ,   88  ,   130 }   ,
                {   4   ,   2   ,   53  ,   147 ,   82  ,   58  ,   69  ,   40  ,   27  ,   117 ,   40  ,   54  ,   116 ,   107 ,   61  }   ,
                {   30  ,   98  ,   123 ,   5   ,   6   ,   116 ,   74  ,   35  ,   116 ,   6   ,   48  ,   78  ,   58  ,   133 ,   149 }   ,
                {   45  ,   4   ,   45  ,   23  ,   112 ,   94  ,   28  ,   46  ,   96  ,   28  ,   37  ,   81  ,   52  ,   70  ,   81  }
            };

            Lab6.TransformArray(testMn, EMode.HorizontalMirror);
            printArray(testMn);

            int[,] test3Row = { { 112, 113, 103, 108, 44, 57, 68, 32, 144, 98, 41, 76, 100, 147, 41, 9, 29, 142, 27 } };

            Lab6.TransformArray(test3Row, EMode.VerticalMirror);
            printArray(test3Row);

            int[,] test3Col ={
                                { 27},
                                { 142} ,
                                { 29} ,
                                { 9} ,
                                { 41} ,
                                { 147} ,
                                { 100} ,
                                { 76} ,
                                { 41} ,
                                { 98} ,
                                { 144} ,
                                { 32} ,
                                { 68} ,
                                { 57 } ,
                                { 44 } ,
                                { 108} ,
                                { 103} ,
                                { 113} ,
                                { 112}
            };

            Lab6.TransformArray(test3Col, EMode.VerticalMirror);
            printArray(test3Col);

            data = getTestArray();

            Lab6.TransformArray(data, EMode.VerticalMirror);
            printArray(data);

            Debug.Assert(isArrayEqual(new int[,]
            {
                { 41, 42, 43, 44, 45, 46 },
                { 31, 32, 33, 34, 35, 36 },
                { 21, 22, 23, 24, 25, 26 },
                { 11, 12, 13, 14, 15, 16 },
                { 1, 2, 3, 4, 5, 6 }
            }, data));

            int[,] test3Mn =
            {
                {   113 ,   103 ,   108 ,   44  ,   57  ,   68  ,   32  ,   144 ,   98  ,   41  ,   76  ,   100 ,   147 ,   41  ,   9   }   ,
                {   29  ,   142 ,   27  ,   21  ,   45  ,   102 ,   78  ,   101 ,   143 ,   79  ,   132 ,   46  ,   20  ,   131 ,   13  }   ,
                {   47  ,   35  ,   20  ,   29  ,   47  ,   29  ,   8   ,   95  ,   27  ,   74  ,   126 ,   60  ,   26  ,   90  ,   110 }   ,
                {   92  ,   18  ,   81  ,   85  ,   33  ,   133 ,   78  ,   29  ,   97  ,   10  ,   34  ,   1   ,   114 ,   114 ,   75  }   ,
                {   22  ,   12  ,   12  ,   85  ,   143 ,   40  ,   80  ,   117 ,   144 ,   130 ,   20  ,   46  ,   0   ,   97  ,   69  }   ,
                {   41  ,   51  ,   11  ,   32  ,   137 ,   113 ,   114 ,   84  ,   97  ,   29  ,   118 ,   6   ,   72  ,   19  ,   12  }   ,
                {   27  ,   43  ,   130 ,   101 ,   51  ,   114 ,   48  ,   91  ,   96  ,   70  ,   11  ,   50  ,   87  ,   105 ,   12  }   ,
                {   86  ,   78  ,   81  ,   28  ,   118 ,   132 ,   140 ,   81  ,   127 ,   111 ,   57  ,   77  ,   64  ,   55  ,   24  }   ,
                {   33  ,   7   ,   98  ,   131 ,   102 ,   127 ,   66  ,   48  ,   46  ,   105 ,   143 ,   110 ,   65  ,   112 ,   126 }   ,
                {   63  ,   27  ,   129 ,   85  ,   93  ,   40  ,   74  ,   44  ,   50  ,   29  ,   37  ,   112 ,   3   ,   140 ,   143 }   ,
                {   36  ,   134 ,   35  ,   72  ,   36  ,   3   ,   101 ,   105 ,   2   ,   35  ,   19  ,   29  ,   35  ,   73  ,   125 }   ,
                {   21  ,   75  ,   119 ,   1   ,   48  ,   29  ,   98  ,   129 ,   112 ,   133 ,   109 ,   113 ,   48  ,   102 ,   65  }   ,
                {   14  ,   63  ,   58  ,   52  ,   68  ,   9   ,   75  ,   142 ,   75  ,   122 ,   111 ,   72  ,   126 ,   49  ,   73  }   ,
                {   11  ,   38  ,   121 ,   74  ,   7   ,   112 ,   142 ,   2   ,   92  ,   114 ,   88  ,   4   ,   73  ,   88  ,   77  }   ,
                {   40  ,   53  ,   2   ,   86  ,   21  ,   106 ,   120 ,   133 ,   4   ,   116 ,   96  ,   82  ,   44  ,   28  ,   86  }   ,
                {   107 ,   121 ,   80  ,   38  ,   121 ,   70  ,   141 ,   124 ,   94  ,   103 ,   21  ,   61  ,   116 ,   88  ,   130 }   ,
                {   4   ,   2   ,   53  ,   147 ,   82  ,   58  ,   69  ,   40  ,   27  ,   117 ,   40  ,   54  ,   116 ,   107 ,   61  }   ,
                {   30  ,   98  ,   123 ,   5   ,   6   ,   116 ,   74  ,   35  ,   116 ,   6   ,   48  ,   78  ,   58  ,   133 ,   149 }   ,
                {   45  ,   4   ,   45  ,   23  ,   112 ,   94  ,   28  ,   46  ,   96  ,   28  ,   37  ,   81  ,   52  ,   70  ,   81  }
            };

            Lab6.TransformArray(test3Mn, EMode.VerticalMirror);
            printArray(test3Mn);

            int[,] test4Row = { { 112, 113, 103, 108, 44, 57, 68, 32, 144, 98, 41, 76, 100, 147, 41, 9, 29, 142, 27 } };

            Lab6.TransformArray(test4Row, EMode.DiagonalShift);
            printArray(test4Row);

            int[,] test4Col ={
                    { 112 } ,
                    { 113 } ,
                    { 103 } ,
                    { 108 } ,
                    { 44  } ,
                    { 57  } ,
                    { 68  } ,
                    { 32  } ,
                    { 144 } ,
                    { 98  } ,
                    { 41  } ,
                    { 76  } ,
                    { 100 } ,
                    { 147 } ,
                    { 41  } ,
                    { 9   } ,
                    { 29  } ,
                    { 142 } ,
                    { 27  }
                };

            Lab6.TransformArray(test4Col, EMode.DiagonalShift);
            printArray(test4Col);

            data = getTestArray();

            Lab6.TransformArray(data, EMode.DiagonalShift);
            printArray(data);

            Debug.Assert(isArrayEqual(new int[,]
            {
                { 46, 41, 42, 43, 44, 45 },
                { 6, 1, 2, 3, 4, 5 },
                { 16, 11, 12, 13, 14, 15 },
                { 26, 21, 22, 23, 24, 25 },
                { 36, 31, 32, 33, 34, 35 }
            }, data));

        }

        private static bool isArrayEqual(int[,] expected, int[,] actual)
        {
            if (expected.GetLength(0) != actual.GetLength(0)
                || expected.GetLength(1) != actual.GetLength(1))
            {
                return false;
            }

            int row = expected.GetLength(0);
            int column = expected.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (expected[i, j] != actual[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static int[,] getTestArray()
        {
            return new int[5, 6]
            {
                { 1, 2, 3, 4, 5, 6 },
                { 11, 12, 13, 14, 15, 16 },
                { 21, 22, 23, 24, 25, 26 },
                { 31, 32, 33, 34, 35, 36 },
                { 41, 42, 43, 44, 45, 46 }
            };
        }

        private static void printArray(int[,] data)
        {
            Console.WriteLine("---------------------------------");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0, -4} ", data[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}

