using System.Diagnostics;
using System.IO;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            // data1.txt
            /*
            AAAAAAAAFFFFFFDDDDDDDSSSSSSS      ssssss
            */

            using (Stream read = File.OpenRead("encode1.txt"))
            using (Stream write = File.OpenWrite("encode1.encoded.bin"))
            {
                bool bEncoded = Encoder.TryEncode(read, write); // true
            }

            // data1.encoded.bin의 이진 데이터
            /*
            08 41 06 46 07 44 07 53 06 20 06 73
            */
        }
    }
}

