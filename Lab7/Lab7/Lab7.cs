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

            return PlayGameRecursive(array, array[0]);
        }

        private static bool PlayGameRecursive(uint[] array, uint currentIndex)
        {
            if (currentIndex >= array.Length - 1)
            {
                // 마지막 요소에 도달한 경우 게임 클리어 가능
                return true;
            }

            uint maxJump = array[currentIndex]; // 인덱스 6의 요소인 2 저장

            // 배열 범위를 벗어나지 않는 선에서 왼쪽 혹은 오른쪽으로 이동하면서 재귀호출
            for (uint i = 1; i <= maxJump && currentIndex + i < array.Length; i++)
            {//                 1 <=        2                     6         + 1 < 10
                if (PlayGameRecursive(array, currentIndex + i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}