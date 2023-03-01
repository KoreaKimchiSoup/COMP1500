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

            index += array[index]; // 오른쪽으로 이동함

            // 마지막 요소에 도달한 경우 true 반환
            if (index == array.Length - 1)
            {
                return true;
            }

            bool success = CanPlusJump(array, index);

            if (!success && index == array[0]) // CanPlusJump 함수가 false 라면?
            {
                index -= array[index];
                System.Console.WriteLine(index);
            }
            // 현재 위치에서 갈 수 있는 범위 내에서 다음 위치를 탐색

            // 모든 경우에 다음 위치에 도달할 수 없는 경우 false 반환
            return false;
        }
    }
}

/*
            for (uint i = array[index]; i <= array[index]; i++)
            {
                if (CanPlusJump(array, index + array[index]))
                {
                    return true;
                }
            }
            */