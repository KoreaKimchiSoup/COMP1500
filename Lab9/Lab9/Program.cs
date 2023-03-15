using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> list1 = new List<int> { 1, 1, 4, 7, 8, 11, 20 };
            List<int> list2 = new List<int> { 2, 3, 4, 5, 10, 15, 16, 21, 22 };

            List<int> combinedList = Lab9.MergeLists(list1, list2);

            for (int i = 0; i < combinedList.Count; ++i)
            {
                Console.WriteLine($"CombinedList: {combinedList[i]}");
            }
            // [ 1, 1, 2, 3, 4, 4, 5, 7, 8, 10, 11, 15, 16, 20, 21, 22 ]
            */

            List<string> keys = new List<string> { "hello", "world", "comp1500", "intro", "to", "c#" };
            List<int> values = new List<int> { 2, 5, 10, 40, -11, -50 };

            Dictionary<string, int> dict1 = Lab9.CombineListsToDictionary(keys, values); // [ { "hello", 2 }, { "world", 5 }, { "comp1500", 10 }, { "intro", 40 }, { "to", -11 }, { "c#", -50 } ]

            List<KeyValuePair<string, int>> keyValuePairs = new List<KeyValuePair<string, int>>(dict1);

            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                Console.WriteLine($"{keyValuePairs[i].Key}: {keyValuePairs[i].Value}");
            }

            keys = new List<string> { "a", "b", "c", "a" };
            values = new List<int> { 1, 2, 3, 4 };

            Dictionary<string, int> dict2 = Lab9.CombineListsToDictionary(keys, values); // [{ "a", 1  }, { "b", 2 }, { "c", 3 }]

            keys = new List<string> { "a", "b", "c", "d" };
            values = new List<int> { 1, 2, 3 };

            Dictionary<string, int> dict3 = Lab9.CombineListsToDictionary(keys, values); // { "a", 1  }, { "b", 2 }, { "c", 3 }

            keys = new List<string> { "a", "b", "c" };
            values = new List<int> { 1, 2, 3, 4 };

            Dictionary<string, int> dict4 = Lab9.CombineListsToDictionary(keys, values); // { "a", 1  }, { "b", 2 }, { "c", 3 }
        }
    }
}
