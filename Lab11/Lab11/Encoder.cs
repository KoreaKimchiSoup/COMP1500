using System.IO;

namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if (input == null)
            {
                return false;
            }



            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            return false;
        }
    }
}