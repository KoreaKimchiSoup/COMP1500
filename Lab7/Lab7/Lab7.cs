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

            // 재귀함수를 호출하여 게임을 진행합니다.
            return CanPlusJump(array, array[0]);
        }

        public static bool CanPlusJump(uint[] array, uint index)
        {
            if (index >= array.Length)
            {
                return false;
            }

            if (index < 0)
            {
                return false;
            }

            // 마지막 위치에 도달한 경우 게임을 클리어하였습니다.
            if (array[index] == 0)
            {
                return true;
            }

            return CanPlusJump(array, index + array[index]);
        }

        /*
        public static bool CanMinusJump(uint[] array, uint index)
        {
            // array[0] - array[index - 0]의 값을 리턴함
            uint returnIndex = array[0] - array[index - 0];
            if (returnIndex > array.Length - 1)
            {
                return false;
            }

            return true;
        }
        */
    }
}