using System.Collections.Generic;

namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            if (array == null || array.Length == 0 || array.Length == 1 || array[0] >= array.Length)
            {
                return false;
            }

            return PlayGameHelper(array, (int)array[0], new HashSet<int>());
        }

        public static bool PlayGameHelper(uint[] array, int currentIndex, HashSet<int> visitedIndices)
        {
            if (currentIndex < 0 || currentIndex >= array.Length || visitedIndices.Contains(currentIndex))
            {
                return false;
            }

            if (array[currentIndex] == 0)
            {
                return true;
            }

            visitedIndices.Add(currentIndex);
            return PlayGameHelper(array, (int)(currentIndex + array[currentIndex]), visitedIndices)
                || PlayGameHelper(array, (int)(currentIndex - array[currentIndex]), visitedIndices);
        }
    }
}