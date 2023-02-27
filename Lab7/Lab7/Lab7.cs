namespace Lab7
{
    public static class Lab7
    {
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
                System.Console.WriteLine("배열의 첫 번째 요소가 배열의 길이보다 크거나 같으면 안됩니다");
                return false;
            }

            return PlayGameRecursive(array, array[0]);
        }

        public static bool PlayGameRecursive(uint[] array, uint index)
        {
            if (index >= array.Length - 1)
            {
                // 마지막 요소에 도달한 경우 게임 클리어 가능
                System.Console.WriteLine("마지막 요소에 도착하였습니다 클리어!");
                return true;
            }
            uint maxJump = array[index];

            System.Console.WriteLine($"현재 배열의 {index}번 인덱스에 위치해 있으며 요소는 {maxJump} 입니다.");
            System.Console.WriteLine($"현재 인덱스 {index}에서 {maxJump} 만큼 이동합니다.");

            // 배열 범위를 벗어나지 않는 선에서 왼쪽 혹은 오른쪽으로 이동하면서 재귀호출
            for (uint i = 1; i <= maxJump && index + i < array.Length; i++)
            {//                 1 <=        2                     6         + 1 < 10
                if (index + maxJump > array.Length - 1)
                {
                    System.Console.WriteLine("배열의 범위를 벋어났습니다");
                    return false;
                }
                if (PlayGameRecursive(array, index + maxJump))
                {
                    return true;
                }
            }

            return false;
        }
    }
}