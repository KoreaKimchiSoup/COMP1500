using System;
using System.Text;
using System.Collections.Generic;

namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            List<int> mergeLists = new List<int>(sortedList1.Count + sortedList2.Count);
            // List1과 2의 길이가 얼마나 될 지 모르기 때문에 for 보단 while이 어울림
            int i = 0;
            int j = 0;
            while (i < sortedList1.Count && j < sortedList2.Count) // i와 j의 값이 두 리스트의 Count보다 작아야함
            {
                if (sortedList1[i] < sortedList2[j])
                {
                    mergeLists.Add(sortedList1[i]);
                    i++;
                }
                else
                {
                    mergeLists.Add(sortedList2[j]);
                    j++;
                }
            }

            while (i < sortedList1.Count) // 체크한 i의 변수가 Count보다 작다면 요소가 더 남은것
            {
                mergeLists.Add(sortedList1[i]);
                i++;
            }

            while (j < sortedList2.Count)
            {
                mergeLists.Add(sortedList2[j]);
                j++;
            }

            return mergeLists;
        }

        public static Dictionary<string, int> CombineListsToDictionary(List<string> keys, List<int> values)
        {
            /* 
               CombineListsToDictionary() 함수는 문자열 리스트 keys와 정수 리스트 values를 인자로 받습니다.
                이 함수는 딕셔너리를 반환하는데 이 딕셔너리의 키(key)는 문자열, 값은 정수 입니다.
                만약 중복된 키가 있다면 첫 번째 값만 저장합니다.
                keys와 values의 길이는 다를 수 있습니다. 이럴 경우 딕셔너리의 크기는 keys의 길이와 values의 길이 중 짧은 것과 같습니다.
             */
            Dictionary<string, int> combineListsToDictionary = new Dictionary<string, int>();

            int minLength = Math.Min(keys.Count, values.Count);

            for (int i = 0; i < minLength; i++)
            {
                if (!combineListsToDictionary.ContainsKey(keys[i]))
                {
                    combineListsToDictionary.Add(keys[i], values[i]);
                }
            }

            List<string> dictionaryKeys = new List<string>(combineListsToDictionary.Keys);

            StringBuilder result = new StringBuilder();
            result.Append("[ ");

            for (int i = 0; i < dictionaryKeys.Count; i++)
            {   
                string key = dictionaryKeys[i];
                result.Append("{ ");
                result.Append($"\"{key}\", {combineListsToDictionary[key]} ");
                result.Append("}");

                if (i < dictionaryKeys.Count - 1)
                {
                    result.Append(", ");
                }
            }

            result.Append(" ]");

            Console.WriteLine(result.ToString());

            return combineListsToDictionary;
        }//asd

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            return null;
        }
    }
}