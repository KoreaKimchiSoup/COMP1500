namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            if (array.Length == 0)
            {
                return false;
<<<<<<< HEAD
            }
            if (array.Length < 2)
            {
                return false;
            }
            return CanPlusJump(array, array[0]);
=======
            }    
            return CanJump(array, array[0]);
>>>>>>> parent of 85c5001 (no message)
        }

        public static bool CanPlusJump(uint[] array, uint index)
        {
            // 범위를 벗어나는 이동인 경우 false 반환
            if (array[array.Length - 1] != 0)
            {
                System.Console.WriteLine("마지막 색인은 0 이어야만 합니다");
                return false;
            }

            if (index == 0)
            {
                System.Console.WriteLine("배열이 비어있으면 안 됩니다");
                return false;
            }
            if (array[0] <= 0)
            {
                System.Console.WriteLine("시작 색인이 0보다 작거나 같을 수 없습니다");
                return false;
            }

            if (index < 0)
            {
                System.Console.WriteLine("색인이 0보다 작을 수 없습니다");
                return false;
            }

            if (index >= array.Length)
            {
                System.Console.WriteLine("색인이 배열의 길이보다 크거나 같을 수 없습니다");
                return false;
            }

            // 마지막 요소에 도달한 경우 true 반환
            if (index == array.Length - 1)
            {
                System.Console.WriteLine("마지막 요소에 도달하였습니다");
                return true;
            }

            uint indexAddArrayIndex = index + array[index];
            //  index + array[index] 디버깅
            

            if (indexAddArrayIndex > array.Length - 1)
            {
                indexAddArrayIndex = array[0] - 1;
                //minusIndex 0으로 계속 초기화 되는거 수정 (전역변수로 선언 하면 안됨) 
            }

            if (CanPlusJump(array, indexAddArrayIndex))
            {
                return true;
            }
            // 현재 위치에서 갈 수 있는 범위 내에서 다음 위치를 탐색
<<<<<<< HEAD

=======
            for (uint i = 1; i <= array[index]; i++)
            {
                if (CanJump(array, index + array[index]))
                {
                    return true;
                }
                if (CanJump(array, index - array[index]))
                {
                    return true;
                }
            }
>>>>>>> parent of 85c5001 (no message)
            // 모든 경우에 다음 위치에 도달할 수 없는 경우 false 반환
            return false;
        }

        public static uint MinusIndex(uint minusIndex)
        {
            uint returnMinusIndex = 0;
            return returnMinusIndex++;
        }
    }
}