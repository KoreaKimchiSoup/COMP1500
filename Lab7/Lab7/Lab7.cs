namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            // 입력받은 배열이 유효한지 검증합니다.
            if (array.Length < 2)
            {
                return false;
            }
            if (array[0] >= array.Length)
            {
                return false;
            }
            if (array[0] == 0)
            {
                return false;
            }
            if (array[array.Length - 1] != 0)
            {
                return false;
            }

            // 재귀함수를 호출하여 게임을 진행합니다.
            return ArrayJumpRecursive(array, array[0]);
        }

        public static bool ArrayJumpRecursive(uint[] array, uint index)
        {
            if (index < 0)
            {
                return false;
            }

            // 마지막 위치에 도달한 경우 게임을 클리어하였습니다.
            if (index == array.Length - 1)
            {
                return true;
            }
            // 3, 4, 4, 2, 8, 6, 0
            index = index + array[index];

            if (index > array.Length - 1)
            {
                index = LeftJump(array, array[0]);
            }

            return ArrayJumpRecursive(array, index);
        }

        public static uint LeftJump(uint[] array, uint index)
        {
            if (index < 0)
            {
                return 0;
            }

            index = index - array[index];
            
            return index;
        }

        /*
        public static uint CanMinusJump(uint[] array, uint index)
        {
            index

            return index;
        }

        public static bool CanMinusJump(uint[] array, uint index)
        {
            array[0] - array[index - 0]의 값을 리턴함
            uint returnIndex = array[0] - array[index - 0];
            if (returnIndex > array.Length - 1)
            {
                return false;
            }

            return true;
        }
        */

        /*
            if (index >= array.Length)
            {//             3    -    2
                index = array[0 - array[index - 0]];
                System.Console.WriteLine(index);
                if (array[0] - index < 0)
                {
                    return false;
                }

                index = array[0] - index;

                if (index > array.Length - 1)
                {
                    return false;
                }
            }
            */
    }
}