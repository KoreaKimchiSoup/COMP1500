using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 1, 4, 7, 8, 11, 20 };
            List<int> list2 = new List<int> { 2, 3, 4, 5, 10, 15, 16, 21, 22 };

            List<int> combinedList = Lab9.MergeLists(list1, list2);

            for (int i = 0; i < combinedList.Count; ++i)
            {
                Console.WriteLine($"CombinedList: {combinedList[i]}");
            }
            // [ 1, 1, 2, 3, 4, 4, 5, 7, 8, 10, 11, 15, 16, 20, 21, 22 ]

            List<string> keys = new List<string> { "a", "b", "c", "a" };
            List<int> values = new List<int> { 1, 2, 3, 4 };

            Dictionary<string, int> dict = Lab9.CombineListsToDictionary(keys, values);
            // [{ "a", 1  }, { "b", 2 }, { "c", 3 }]
        }
    }
}
