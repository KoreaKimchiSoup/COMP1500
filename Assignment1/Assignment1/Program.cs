using System;
using System.IO;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string integerInput = "52\n102\n1\n2382\n409"; // PrintIntegers() Auto input
            string floatInput = "2.23\n-1912.87233125\n2323\n1\n34.55567"; // PrintStats() Auto input
            byte[] buffer1 = Encoding.UTF8.GetBytes(integerInput);
            byte[] buffer2 = Encoding.UTF8.GetBytes(floatInput);

            using (StreamReader READER1 = new StreamReader(new MemoryStream(buffer1)))
            using (StreamReader READER2 = new StreamReader(new MemoryStream(buffer2)))
            using (StreamWriter WRITER = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true })
            {
                Console.WriteLine("PrintIntegers()\n");
                Assignment1.PrintIntegers(READER1, WRITER, 14); // width : 14

                Console.WriteLine("\nPrintStats()\n");
                Assignment1.PrintStats(READER2, WRITER);
            }
        }

    }
}