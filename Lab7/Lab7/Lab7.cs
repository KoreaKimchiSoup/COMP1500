namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            if (array.Length == 0)
            {
                return false;
            }
            if (array.Length < 2)
            {
                return false;
            }
            return CanPlusJump(array, array[0]);
        }

        public static bool CanPlusJump(uint[] array, uint index)
        {
            // 범위를 벗어나는 이동인 경우 false 반환
            if (index < 0 || index >= array.Length)
            {
                return false;
            }
            // 마지막 요소에 도달한 경우 true 반환
            if (index == array.Length - 1)
            {
                return true;
            }
            // 현재 위치에서 갈 수 있는 범위 내에서 다음 위치를 탐색
            for (uint i = 1; i <= array[index]; i++)
            {
                if (CanPlusJump(array, index + array[index])) // index + array[index] 의 값이 밑의 if문에도 전달이 될까?
                {
                    return true;
                }
                if (index + array[index] > array.Length - 1)
                {
                    CanMinusJump(array, array[index]);
                }
            }
            // 모든 경우에 다음 위치에 도달할 수 없는 경우 false 반환
            return false;
        }

        public static bool CanMinusJump(uint[] array, uint index)
        {
            // 초기 배열과 index값을 받아서 초기 index 값의 요소 만큼 왼쪽으로 한번 이동하고 다시 오른쪽 쭉 이동
            // 한번 왼쪽으로 안된다면 될 때 까지 이동
            return false;
        }
    }
}