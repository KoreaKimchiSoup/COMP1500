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

        }
    }
}