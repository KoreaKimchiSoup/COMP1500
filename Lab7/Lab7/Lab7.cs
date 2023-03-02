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
                System.Console.WriteLine("배열의 길이가 2보다 작으면 안됩니다");
                return false;
            }
            

            return PlayGameRecursive(array, array[0]);
        }

        public static bool PlayGameRecursive(uint[] array, uint index)
        {
            if (index == array.Length - 1)
            {
                System.Console.WriteLine("마지막 요소에 도착하였습니다");
                return true;
            }

            if (index > array.Length - 1)
            {
                System.Console.WriteLine("인덱스가 배열의 길이를 넘었습니다");
                return false;
            }

            if (array[0] >= array.Length)
            {
                System.Console.WriteLine("배열의 첫 번째 요소가 배열의 길이보다 크거나 같으면 안됩니다");
                return false;
            }

            uint maxJump = array[index];

            if (PlayGameRecursive(array, index + maxJump))
            { 
                return true;
            }

            return false;
        }
    }
}