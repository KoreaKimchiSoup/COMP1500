namespace Assignment2
{
    public static class Canvas
    {
        static char[][] Draw(uint width, uint height, EShape shape)
        {
            char[][] charArray =  new char[width][height];

            if (width == 0 || height == 0)
            {
                char[][] voidArray = new char[0][];
                return voidArray;
            }
        }
    }
}