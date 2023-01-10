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

            if (width < 10)
            {
                width = 10;
                output.Write(oct.PadLeft(width));
                output.Write(dec.PadLeft(width));
                output.WriteLine(hex.PadLeft(width));
            }
            output.Write(Convert.ToString(num1, 8).PadLeft(width));
            output.Write(Convert.ToString(num1, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num1, 16).PadLeft(width));

            output.Write(Convert.ToString(num2, 8).PadLeft(width));
            output.Write(Convert.ToString(num2, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num2, 16).PadLeft(width));

            output.Write(Convert.ToString(num3, 8).PadLeft(width));
            output.Write(Convert.ToString(num3, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num3, 16).PadLeft(width));

            output.Write(Convert.ToString(num4, 8).PadLeft(width));
            output.Write(Convert.ToString(num4, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num4, 16).PadLeft(width));

            output.Write(Convert.ToString(num5, 8).PadLeft(width));
            output.Write(Convert.ToString(num5, 10).PadLeft(width));
            output.WriteLine(Convert.ToString(num5, 16).PadLeft(width));
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            double s1 = double.Parse(input.ReadLine());
            double s2 = double.Parse(input.ReadLine());
            double s3 = double.Parse(input.ReadLine());
            double s4 = double.Parse(input.ReadLine());
            double s5 = double.Parse(input.ReadLine());

            double[] numbers = new double[] { s1, s2, s3, s4, s5 };
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
            double sum = s1 + s2 + s3 + s4 + s5;
            double average = sum / numbers.Length;

            output.WriteLine($"Min Value:{min}");
            output.WriteLine($"Max Value:{max}");
            output.WriteLine($"Sum:{sum:f3}");
            output.WriteLine($"Average:{average:f3}");
            
        }
    }
}