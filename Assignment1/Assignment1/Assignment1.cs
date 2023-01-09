using System;
using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            string s1 = input.ReadLine();
            string s2 = input.ReadLine();
            string s3 = input.ReadLine();
            string s4 = input.ReadLine();
            string s5 = input.ReadLine();
            output.WriteLine(Convert.ToString(s1));
            output.WriteLine(s2);
            output.WriteLine(s3);
            output.WriteLine(s4);
            output.WriteLine(s5);
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {

        }
    }
}