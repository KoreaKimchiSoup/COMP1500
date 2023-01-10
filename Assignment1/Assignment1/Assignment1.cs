using System;
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
            string oct = "oct";
            string dec = "dec";
            string hex = "hex";

            if (width <= 9)
            {
                width = 10;
                output.Write(oct.PadLeft(width + 1));
                output.Write(dec.PadLeft(width));
                output.WriteLine(hex.PadLeft(width + 1));
            }
            output.Write(Convert.ToString(num1, 8).PadLeft(width + 1));
            output.Write(Convert.ToString(num1, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num1, 16).PadLeft(width + 1));

            output.Write(Convert.ToString(num2, 8).PadLeft(width + 1));
            output.Write(Convert.ToString(num2, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num2, 16).PadLeft(width + 1));

            output.Write(Convert.ToString(num3, 8).PadLeft(width + 1));
            output.Write(Convert.ToString(num3, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num3, 16).PadLeft(width + 1));

            output.Write(Convert.ToString(num4, 8).PadLeft(width + 1));
            output.Write(Convert.ToString(num4, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num4, 16).PadLeft(width + 1));

            output.Write(Convert.ToString(num5, 8).PadLeft(width + 1));
            output.Write(Convert.ToString(num5, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num5, 16).PadLeft(width + 1));
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            double num1 = double.Parse(input.ReadLine());
            double num2 = double.Parse(input.ReadLine());
            double num3 = double.Parse(input.ReadLine());
            double num4 = double.Parse(input.ReadLine());
            double num5 = double.Parse(input.ReadLine());

            double[] numbers = new double[] { num1, num2, num3, num4, num5 };
            double max = numbers[0];
            double min = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            double sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / numbers.Length;
            string stringMin = "Min";
            string stringMax = "Max";
            string stringSum = "Sum";
            string stringAverage = "average";

            output.WriteLine("{0, 25:f3}", num1);
            output.WriteLine("{0, 25:f3}", num2);
            output.WriteLine("{0, 25:f3}", num3);
            output.WriteLine("{0, 25:f3}", num4);
            output.WriteLine("{0, 25:f3}", num5);
            output.WriteLine("{0, -10:f3}{1, 15}", stringMin, min);
            output.WriteLine("{0, -10:f3}{1, 15}", stringMax, max);
            output.WriteLine("{0, -10:f3}{1, 15}", stringSum, sum);
            output.WriteLine("{0, -10:f3}{1, 15}", stringAverage, average);

        }
    }
}