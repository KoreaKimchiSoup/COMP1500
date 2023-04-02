using System.Diagnostics;
using System.IO;

namespace Lab11
{
    class Program
    {
        private const string ENCODE_TEST1 = "encode1.txt";
        private const string ENCODE_TEST2 = "encode2.txt";

        private const string DECODE_TEST1 = "decode1.bin";
        private const string DECODE_TEST2 = "decode2.bin";

        private const string EMPTY_ENCODE_TEST = "empty_encode.txt";
        private const string EMPTY_DECODE_TEST = "empty_decode.bin";

        static void Main(string[] args)
        {
            setup();

            using (Stream read = File.OpenRead(ENCODE_TEST1))
            using (Stream write = File.OpenWrite($"{ENCODE_TEST1}.output.bin"))
            {
                bool bEncoded = Encoder.TryEncode(read, write);
                // encode1.txt.output.bin과 decode1.bin의 내용이 같아야 함
                Debug.Assert(bEncoded);
            }

            using (Stream read = File.OpenRead(DECODE_TEST1))
            using (Stream write = File.OpenWrite($"{DECODE_TEST1}.output.txt"))
            {
                bool bEncoded = Encoder.TryDecode(read, write);
                // decode1.bin.output.txt과 encode1.txt의 내용이 같아야 함
                Debug.Assert(bEncoded);
            }

            using (Stream read = File.OpenRead(ENCODE_TEST2))
            using (Stream write = File.OpenWrite($"{ENCODE_TEST2}.output.bin"))
            {
                bool bEncoded = Encoder.TryEncode(read, write);
                // encode2.txt.output.bin과 decode2.bin의 내용이 같아야 함
                Debug.Assert(bEncoded);
            }

            using (Stream read = File.OpenRead(DECODE_TEST2))
            using (Stream write = File.OpenWrite($"{DECODE_TEST2}.output.txt"))
            {
                bool bEncoded = Encoder.TryDecode(read, write);
                // decode2.bin.output.txt과 encode2.txt의 내용이 같아야 함
                Debug.Assert(bEncoded);
            }

            using (Stream read = File.OpenRead(EMPTY_ENCODE_TEST))
            using (Stream write = File.OpenWrite($"{EMPTY_ENCODE_TEST}.output.bin"))
            {
                bool bEncoded = Encoder.TryEncode(read, write);
                // empty_encode.txt.output.bin의 내용이 비어 있어야 함
                Debug.Assert(!bEncoded);
            }

            using (Stream read = File.OpenRead(EMPTY_DECODE_TEST))
            using (Stream write = File.OpenWrite($"{EMPTY_DECODE_TEST}.output.txt"))
            {
                bool bEncoded = Encoder.TryDecode(read, write);
                // empty_decode.bin.output.txt의 내용이 비어 있어야 함
                Debug.Assert(!bEncoded);
            }
        }

        private static void setup()
        {
            if (File.Exists($"{ENCODE_TEST1}.output.bin"))
            {
                File.Delete($"{ENCODE_TEST1}.output.bin");
            }

            if (File.Exists($"{DECODE_TEST1}.output.txt"))
            {
                File.Delete($"{DECODE_TEST1}.output.txt");
            }

            if (File.Exists($"{ENCODE_TEST2}.output.bin"))
            {
                File.Delete($"{ENCODE_TEST2}.output.bin");
            }

            if (File.Exists($"{DECODE_TEST2}.output.txt"))
            {
                File.Delete($"{DECODE_TEST2}.output.txt");
            }

            if (File.Exists($"{EMPTY_ENCODE_TEST}.output.bin"))
            {
                File.Delete($"{EMPTY_ENCODE_TEST}.output.bin");
            }

            if (File.Exists($"{EMPTY_DECODE_TEST}.output.txt"))
            {
                File.Delete($"{EMPTY_DECODE_TEST}.output.txt");
            }
        }
    }
}