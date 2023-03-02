namespace Lab7
{
    public static class Lab7
    {//asd
        public static bool PlayGame(uint[] array)
        {
            if (array.Length == 0)
            {
                System.Console.WriteLine("배열이 비어있을 수 없습니다");
                return false;
            }
            if (array.Length < 2)
            {
                System.Console.WriteLine("배열의 길이가 1 이하이면 안됩니다");
                return false;
            }
            if (array[0] >= array.Length) // 추가
            {
                System.Console.WriteLine("배열의 첫 번째 요소가 배열의 길이보다 크면 안됩니다");
                return false;
            }

            return PlayGameRecursive(array, array[0]);
        }

        public static bool PlayGameRecursive(uint[] array, uint index)
        {
            if (index == array.Length - 1)
            {
                return true;
            }

            if (index > array.Length - 1)
            {
                return false;
            }

            uint maxJump = array[index];

            // 배열 범위를 벗어나지 않는 선에서 왼쪽 혹은 오른쪽으로 이동하면서 재귀호출
            if (index > array.Length)
            {
                return false;
            }

            if (PlayGameRecursive(array, index + maxJump))
            {
                return true;
            }

            if (maxJump < array.Length - 1)
            {
                maxJump = index - array[index];
                PlayGameRecursive(array, maxJump);
            }

            return false;
        }
    }
}