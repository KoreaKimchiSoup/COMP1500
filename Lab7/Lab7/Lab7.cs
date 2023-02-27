namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            if (array.Length == 0) // 배열이 비었는지
            {
                return false;
            }
            if (array.Length == 1) // 배열의 길이가 1인지 (1 이상이어야 함)
            {
                return false;
            }
            if (array.Length < array[0]) // 첫 번째 요소가 배열의 길이보다 작거나 같은지)
            {
                return false;
            }

            // 배열의 첫 번째 요소는 플레이어가 시작하는 위치를 가리킴
            // 첫 번째 요소가 가리키는 요소로 이동한 후 해당 요소의 값, 또는
            // 해당 요소의 다음 수 부터 마지막 요소인 0 까지 '정확히' 이동할 수
            // 있는지 여부를 검사함

            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine($"배열의 요소 {array[i]} 가 있습니다");
            }
            System.Console.WriteLine($"배열의 길이는 {array.Length} 입니다.");
            System.Console.WriteLine($"첫 번째 요소가 {array[0]} 이므로 {array[0]} 만큼 이동하여 플레이어가 있는 위치는 " +
                $"{array[0 + array[0]]} 입니다");

            if (array[0 + array[0]] == 0)
            {
                return true;
            }

            return false;
        }
    }
}