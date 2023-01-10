using System;
using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            int s1 = int.Parse(input.ReadLine());
            int s2 = int.Parse(input.ReadLine());
            int s3 = int.Parse(input.ReadLine());
            int s4 = int.Parse(input.ReadLine());
            int s5 = int.Parse(input.ReadLine());
            output.WriteLine("{0, 14}{1, 14}{2,14}", "oct", "dec", "hex");
            output.WriteLine($"s1: {s1} -> {Convert.ToString(s1, 8)}");
            output.WriteLine($"s1: {s1} -> {Convert.ToString(s1, 10)}");
            output.WriteLine($"s1: {s1} -> {Convert.ToString(s1, 16)}");

            Console.WriteLine();

            output.WriteLine($"s2: {s2} -> {Convert.ToString(s2, 8)}");
            output.WriteLine($"s2: {s2} -> {Convert.ToString(s2, 10)}");
            output.WriteLine($"s2: {s2} -> {Convert.ToString(s2, 16)}");

            Console.WriteLine();

            output.WriteLine($"s3: {s3} -> {Convert.ToString(s3, 8)}");
            output.WriteLine($"s3: {s3} -> {Convert.ToString(s3, 10)}");
            output.WriteLine($"s3: {s3} -> {Convert.ToString(s3, 16)}");

            Console.WriteLine();

            output.WriteLine($"s4: {s4} -> {Convert.ToString(s4, 8)}");
            output.WriteLine($"s4: {s4} -> {Convert.ToString(s4, 10)}");
            output.WriteLine($"s4: {s4} -> {Convert.ToString(s4, 16)}");

            Console.WriteLine();

            output.WriteLine($"s5: {s5} -> {Convert.ToString(s5, 8)}");
            output.WriteLine($"s5: {s5} -> {Convert.ToString(s5, 10)}");
            output.WriteLine($"s5: {s5} -> {Convert.ToString(s5, 16)}");

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