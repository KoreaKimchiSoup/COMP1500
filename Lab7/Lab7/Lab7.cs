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
            if (array.Length == 1)
            {
                return false;
            }
            if (array[0] >= array.Length)
            {
                return false;
            }

            // 0번 요소를 유동적이게 만들어야함 다음 번 요소는 0번 인덱스의 요소가 아닌
            // 이동한 만큼의 인덱스에 있는 요소여야 함 -> 해답: 이동한 요소의 값을 변수에 중첩?
            // 함수가 다시 실행될 때마다 이것을 반복?
            if (array[0 + array[0]] != 0)
            {

            }
            주어진 배열의 첫 번째 요소를 확인 후 같은 인덱스값이 플레이어의 위치점이고

            플레이어의 위치점에 있는 요소가 0이 아니라면 플레이어의 위치에 있는 요소값 만큼 이동합니다

            이동한 거리가 배열의 크기를 벗어난다면 false 입니다
            
            if (현재 플레이어의 위치의 요소가 0이라면)
            {
                return true;
            }

            PlayGame();
            0이 아니라면 다시 함수를 호출해서 현재 인덱스의 요소값 만큼 이동합니다
            
            
            
            
            
            
            
            
            
            
            
            
            /*
            for (int i = 0; i < 1; i++)
            {
                System.Console.WriteLine("배열의 요소는 ");
                for (int j = 0; j < array.Length; j++)
                {
                    System.Console.Write($"{array[j]} ");
                }
                System.Console.WriteLine("입니다");
                System.Console.WriteLine($"배열의 길이는 {array.Length} 입니다.");
            }
            System.Console.WriteLine($"첫 번째 요소가 {array[0]} 이므로 {array[0]} 만큼 이동하여 플레이어가 있는 위치는 " +
                $"{array[0 + array[0]]} 입니다");

            
            */
            
            return false;
        }
    }
}