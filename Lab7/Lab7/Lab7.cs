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
            if (index < 0)
            {
                return false;
            }

            if (index >= array.Length)
            {
                return false;
            }

            // 마지막 요소에 도달한 경우 true 반환
            if (index == array.Length - 1)
            {
                return true;
            }

            uint indexAddArrayIndex = index + array[index];
            //  index + array[index] 디버깅
            uint minusIndex = 0;

            if (indexAddArrayIndex > array.Length - 1)
            {
                minusIndex++;
                indexAddArrayIndex = array[0] - minusIndex;
                //minusIndex 0으로 계속 초기화 되는거 수정
            }

            if (CanPlusJump(array, indexAddArrayIndex))
            {
                return true;
            }
            // 현재 위치에서 갈 수 있는 범위 내에서 다음 위치를 탐색

            // 모든 경우에 다음 위치에 도달할 수 없는 경우 false 반환
            return false;
        }
    }
}

/*
            
            */