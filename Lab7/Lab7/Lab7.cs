using System.Collections.Generic;

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
            bool[] visitedIndices = new bool[array.Length];
            return ArrayJumpRecursive(array, array[0], visitedIndices);
        }

        public static bool ArrayJumpRecursive(uint[] array, uint currentIndex, bool[] visitedIndices)
        {
            if (currentIndex < 0 || currentIndex >= array.Length || visitedIndices[currentIndex])
            {
                return false;
            }
            if (array[currentIndex] == 0)
            {
                return true;
            }
            visitedIndices[currentIndex] = true;
            return ArrayJumpRecursive(array, (currentIndex + array[currentIndex]), visitedIndices)
                || ArrayJumpRecursive(array, (currentIndex - array[currentIndex]), visitedIndices);
        }
        /*
        public static uint LeftJump(uint[] array, uint index)
        {
            // { 3, 4, 4, 2, 8, 6, 0 }

            if (index < 0)
            {
                return 0;
            }

            index = index - array[index];
            uint visitedIndex = 0;

            if (visitedIndex == index)
            {
                return 0;
            }

            visitedIndex = index;

            return index;
        }
        */
    }
}