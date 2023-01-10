using System.Diagnostics;
using System.IO;
using System.Text;
using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string integerInput = "25\n26\n10\n22\n16";
            string floatInput = "12.5\n25.262\n12\n10008.2\n-1224.2";

            byte[] buffer1 = Encoding.UTF8.GetBytes(integerInput);
            byte[] buffer2 = Encoding.UTF8.GetBytes(floatInput);


            // using 문에 대해서는 아직 고민하지 마세요. 나중에 배웁니다.
            using (StreamReader READER1 = new StreamReader(new MemoryStream(buffer1)))
            using (StreamReader READER2 = new StreamReader(new MemoryStream(buffer2)))
            //using (StreamReader READER = new StreamReader(Console.OpenStandardInput()))
           
            using (StreamWriter WRITER = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true })
            {
                Console.WriteLine("Enter your 5 digits for PrintIntegers():");
                Assignment1.PrintIntegers(READER1, WRITER, 1);

                Console.WriteLine("Enter your 5 digits for PrintStats():");
                Assignment1.PrintStats(READER2, WRITER);
            }            
        }
    }
}

/*
     double[] numbers = new double[] { 3.14, 2.718, 1.618, 6.02, 9.8 }; 
     double max = numbers[0]; 
     double min = numbers[0];

     for (int i = 1; i < numbers.Length; i++) 
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
 */ 