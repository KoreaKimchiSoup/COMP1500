﻿using System;
using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            int num1 = int.Parse(input.ReadLine());
            int num2 = int.Parse(input.ReadLine());
            int num3 = int.Parse(input.ReadLine());
            int num4 = int.Parse(input.ReadLine());
            int num5 = int.Parse(input.ReadLine());

            string numOct1 = Convert.ToString(num1, 8);
            string numDec1 = Convert.ToString(num1, 10);
            string numHex1 = Convert.ToString(num1, 16).ToUpper();

            string numOct2 = Convert.ToString(num2, 8);
            string numDec2 = Convert.ToString(num2, 10);
            string numHex2 = Convert.ToString(num2, 16).ToUpper();

            string numOct3 = Convert.ToString(num3, 8);
            string numDec3 = Convert.ToString(num3, 10);
            string numHex3 = Convert.ToString(num3, 16).ToUpper();

            string numOct4 = Convert.ToString(num4, 8);
            string numDec4 = Convert.ToString(num4, 10);
            string numHex4 = Convert.ToString(num4, 16).ToUpper();

            string numOct5 = Convert.ToString(num5, 8);
            string numDec5 = Convert.ToString(num5, 10);
            string numHex5 = Convert.ToString(num5, 16).ToUpper();

            if (width < 10)
            {
                return;
            }
            else
            {
                width = 10;
                output.Write("oct".PadRight(width));
                output.Write("dec".PadRight(width));
                output.WriteLine("hex".PadRight(width));
            }

            output.Write(string.Format("{0," + width + "}", numOct1));
            output.Write(string.Format("{0," + width + "}", numDec1));
            output.WriteLine(string.Format("{0," + width + "}", numHex1));

            output.Write(string.Format("{0," + width + "}", numOct2));
            output.Write(string.Format("{0," + width + "}", numDec2));
            output.WriteLine(string.Format("{0," + width + "}", numHex2));

            output.Write(string.Format("{0," + width + "}", numOct3));
            output.Write(string.Format("{0," + width + "}", numDec3));
            output.WriteLine(string.Format("{0," + width + "}", numHex3));

            output.Write(string.Format("{0," + width + "}", numOct4));
            output.Write(string.Format("{0," + width + "}", numDec4));
            output.WriteLine(string.Format("{0," + width + "}", numHex4));

            output.Write(string.Format("{0," + width + "}", numOct5));
            output.Write(string.Format("{0," + width + "}", numDec5));
            output.WriteLine(string.Format("{0," + width + "}", numHex5));

            /*
            output.Write(string.Format("{0, 10:X}", num1));
            output.Write(Convert.ToString(num1, 8).PadLeft(width));
            output.Write(Convert.ToString(num1, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num1, 16).PadLeft(width).ToUpper());

            output.Write(Convert.ToString(num2, 8).PadLeft(width));
            output.Write(Convert.ToString(num2, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num2, 16).PadLeft(width).ToUpper());

            output.Write(Convert.ToString(num3, 8).PadLeft(width));
            output.Write(Convert.ToString(num3, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num3, 16).PadLeft(width).ToUpper());

            output.Write(Convert.ToString(num4, 8).PadLeft(width));
            output.Write(Convert.ToString(num4, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num4, 16).PadLeft(width).ToUpper());

            output.Write(Convert.ToString(num5, 8).PadLeft(width));
            output.Write(Convert.ToString(num5, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num5, 16).PadLeft(width).ToUpper());
            */
        }
        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            double num1 = double.Parse(input.ReadLine());
            double num2 = double.Parse(input.ReadLine());
            double num3 = double.Parse(input.ReadLine());
            double num4 = double.Parse(input.ReadLine());
            double num5 = double.Parse(input.ReadLine());

            double min = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));
            double max = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));

            double sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / 5;

            string stringMin = "Min";
            string stringMax = "Max";
            string stringSum = "Sum";
            string stringAverage = "Average";

            output.WriteLine("{0, 24:f3}", num1);
            output.WriteLine("{0, 24:f3}", num2);
            output.WriteLine("{0, 24:f3}", num3);
            output.WriteLine("{0, 24:f3}", num4);
            output.WriteLine("{0, 24:f3}", num5);
            output.WriteLine("{0}{1, 21:f3}", stringMin, min);
            output.WriteLine("{0}{1, 21:f3}", stringMax, max);
            output.WriteLine("{0}{1, 21:f3}", stringSum, sum);
            output.WriteLine("{0}{1, 17:f3}", stringAverage, average);

        }
    }
}