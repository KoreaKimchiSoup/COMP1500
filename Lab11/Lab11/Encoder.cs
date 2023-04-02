using System.IO;

namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            int currentChar = -1;
            int previousChar = -1;
            int count = 0;

            while ((currentChar = input.ReadByte()) != -1)
            {
                if (currentChar == previousChar)
                {
                    count++;
                    if (count == 255)
                    {
                        output.WriteByte((byte)count);
                        output.WriteByte((byte)previousChar);
                        count = 1;
                    }
                }

                else
                {
                    if (previousChar != -1)
                    {
                        output.WriteByte((byte)count);
                        output.WriteByte((byte)previousChar);
                    }

                    count = 1;
                }

                previousChar = currentChar;
            }

            if (count > 0)
            {
                output.WriteByte((byte)count);
                output.WriteByte((byte)previousChar);
            }

            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            int count;
            int currentChar;

            while ((count = input.ReadByte()) != -1)
            {
                currentChar = input.ReadByte();
                for (int i = 0; i < count; ++i)
                {
                    output.WriteByte((byte)currentChar);
                }
            }

            return true;
        }
    }
}