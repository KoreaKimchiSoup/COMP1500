namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            // 입력받은 배열이 유효한지 검증합니다.
            if (array.Length < 2)
            {
                return false;
            }

            if (array[0] >= array.Length)
            {
                return false;
            }

            if (array[0] == 0)
            {
                return false;
            }

            if (array[array.Length - 1] != 0)
            {
                return false;
            }

            bool[] visitIndex = new bool[array.Length]; 

            return ArrayJumpRecursive(array, array[0], visitIndex);
        }

        public static bool ArrayJumpRecursive(uint[] array, uint index, bool[] visitIndex)
        {
            if (index < 0)
            {
                return false;
            }

            if (index >= array.Length)
            {
                return false;
            }

            if (visitIndex[index])
            {
                return false;
            }

            if (array[index] == 0)
            {
                return true;
            }

            visitIndex[index] = true;

            return ArrayJumpRecursive(array, (index + array[index]), visitIndex) ||
                       ArrayJumpRecursive(array, (index - array[index]), visitIndex);
        }
    }
}