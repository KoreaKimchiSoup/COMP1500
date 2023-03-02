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
            return CanJump(array, array[0]);
        }

        public static bool CanJump(uint[] array, uint index)
        {
            // 현재 위치가 유효한 범위 내에 있는지 검증합니다.
            if (index < 0 || index >= array.Length)
            {
                return false;
            }

            // 마지막 위치에 도달한 경우 게임을 클리어하였습니다.
            if (array[index] == 0)
            {
                return true;
            }

            if (CanJump(array, index + array[index]))
            {
                return true;
            }

            // 모든 경우에 이동할 수 없는 경우 게임을 클리어할 수 없습니다.
            return false;
        }
    }
}