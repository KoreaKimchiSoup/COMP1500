using System;
using System.Collections.Generic;

namespace Assignment3
{
    public static class TowerOfHanoi
    {
        /*
        본 실습은 컴퓨터에서 해야 하는 과제입니다. 코드 작성이 끝났다면 깃 저장소에 커밋 및 푸쉬를 하고 슬랙을 통해 자동으로 채점을 받으세요.

        앞으로 코드를 많이 작성하다 보면 데이터를 저장하는 다양한 방법 중에서 하나를 택해야 할 일이 있을 것입니다. 보통은 용도에 딱 맞는 자료 해도 한두 개 존재하지만, 그렇지 않은 경우도 있죠. 이럴 때는 결국 둘 이상의 자료 구조(예: 배열과 키/값 쌍)를 함께 사용해야 할 수도 있습니다. 이때, 유틸리티 함수 몇 개를 작성해 두면 참 편할 것 같네요. 서로 다른 자료 구조 간에 변환을 해 주거나, 여러 자료 구조를 하나로 합치거나, 한 자료구조를 여러 개로 분리하는 등의 기능을 가진 함수들이요.


        Lab9 클래스 안에 있는 함수 구현하기
전반적인 규칙
System.Linq를 사용할 수 없습니다. 사용하면 0점이 뜨니 시도조차 하지 마세요. :)
Systems.Collections.Generics 네임스페이스 아래 List<T>와 Dictionary<TKey, TValue>만 사용할 수 있습니다. 다른 클래스를 사용하면 0점이 뜨니 시도조차 하지 마세요. :)
List<T>의 Sort(), AddRange(), 또는 Array의 Sort() 함수를 사용할 수 없습니다. 사용하면 0점이 뜨니 시도조차 하지 마세요. :)
Array의 Sort() 함수를 사용할 수 없습니다. 사용하면 0점이 뜨니 시도조차 하지 마세요. :)
List<T>의 다음 함수들을 사용할 수 없습니다. 사용하면 0점이 뜨니 시도조차 하지 마세요. :)
Sort()
AddRange()
ConvertAll()
2.1 MergeLists() 함수를 구현한다
MergeLists() 함수는 오름차순으로 정렬된 정수 리스트 두 개를 인자로 받습니다.
이 함수는 두 정수 리스트를 하나로 합친 새로운 리스트를 반환합니다. 이 리스트도 오름차순으로 정렬되어 있어야 합니다.
인자로 들어오는 두 리스트는 언.제.나. 정렬되어 있다는 사실 잊지 마세요.
List<int> list1 = new List<int> { 1, 1, 4, 7, 8, 11, 20 };
List<int> list2 = new List<int> { 2, 3, 4, 5, 10, 15, 16, 21, 22 };

List<int> combinedList = Lab9.MergeLists(list1, list2);
// [ 1, 1, 2, 3, 4, 4, 5, 7, 8, 10, 11, 15, 16, 20, 21, 22 ]
2.2 CombineListsToDictionary() 함수를 구현한다
CombineListsToDictionary() 함수는 문자열 리스트 keys와 정수 리스트 values를 인자로 받습니다.
이 함수는 딕셔너리를 반환하는데 이 딕셔너리의 키(key)는 문자열, 값은 정수 입니다.
만약 중복된 키가 있다면 첫 번째 값만 저장합니다.
keys와 values의 길이는 다를 수 있습니다. 이럴 경우 딕셔너리의 크기는 keys의 길이와 values의 길이 중 짧은 것과 같습니다.
List<string> keys = new List<string> { "hello", "world", "comp1500", "intro", "to", "c#" };
List<int> values = new List<int> { 2, 5, 10, 40, -11, -50 };

Dictionary<string, int> dict = Lab9.CombineListsToDictionary(keys, values); // [ { "hello", 2 }, { "world", 5 }, { "comp1500", 10 }, { "intro", 40 }, { "to", -11 }, { "c#", -50 } ]

keys = new List<string> { "a", "b", "c", "a" };
values = new List<int> { 1, 2, 3, 4 };

Dictionary<string, int> dict = Lab9.CombineListsToDictionary(keys, values); // [{ "a", 1  }, { "b", 2 }, { "c", 3 }]

keys = new List<string> { "a", "b", "c", "d" };
values = new List<int> { 1, 2, 3 };

Dictionary<string, int> dict = Lab9.CombineListsToDictionary(keys, values); // { "a", 1  }, { "b", 2 }, { "c", 3 }

keys = new List<string> { "a", "b", "c" };
values = new List<int> { 1, 2, 3, 4 };

Dictionary<string, int> dict = Lab9.CombineListsToDictionary(keys, values); // { "a", 1  }, { "b", 2 }, { "c", 3 }
2.3 MergeDictionaries() 함수를 구현한다
MergeDictionaries() 함수는 Dictionary<string, int> numerators와 Dictionary<string, int> denominators를 인자로 받습니다..
이 함수는 Dictionary<string, decimal>을 반환하는데 다음의 규칙에 따라 이 반환 값을 만듭니다.
만약 numerators와 denominators 중 하나라도 비어있다면 빈 딕셔너리를 반환합니다.
만약 어떤 키 하나가 numerators와 denominators 양쪽에 모두 존재한다면 numerators에서 그 키에 대응하는 값을 denominators에서 그 키에 대응하는 값으로 나눕니다. 만약 denominators에서 가져온 값이 0이라면 그 키를 무시합니다. 만약 결괏값이 음수라면 절댓값을 대신 사용합니다.
2)에서 계산한 결괏값을 딕셔너리에 추가합니다. 이때, 키는 2)에서 사용한 것과 같습니다.
Dictionary<string, int> numerators = new Dictionary<string, int>
{
    { "a", 53 },
    { "b", -14 },
    { "c", 5 },
    { "d", 235 },
    { "g", 1 },
    { "h", 4 }
};
Dictionary<string, int> denominators = new Dictionary<string, int>
{
    { "a", 77 },
    { "b", 235 },
    { "c", -3 },
    { "d", 121 },
    { "e", 8 },
    { "f", -621 },
    { "h", 0 }
};

Dictionary<string, decimal> result = Lab9.MergeDictionaries(numerators, denominators);
// [ { a, 0.6883116883116883116883116883 }, { b, 0.0595744680851063829787234043 }, { c, 1.6666666666666666666666666667 }, { d, 1.9421487603305785123966942149 } ]
3. 본인 컴퓨터에서 테스트하는 법
Program.cs 파일 안 Main() 함수에서 다음과 같이 테스트를 해주세요
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 1, 4, 7, 8, 11, 20 };
            List<int> list2 = new List<int> { 2, 3, 4, 5, 10, 15, 16, 21, 22 };

            List<int> combinedList = Lab9.MergeLists(list1, list2);
            List<int> expectedList = new List<int> { 1, 1, 2, 3, 4, 4, 5, 7, 8, 10, 11, 15, 16, 20, 21, 22 };

            Console.WriteLine($"[ {string.Join(", ", combinedList)} ]");

            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Assert(expectedList[i] == combinedList[i]);
            }

            List<string> keys = new List<string> { "hello", "world", "comp1500", "intro", "to", "c#" };
            List<int> values = new List<int> { 2, 5, 10, 40, -11, -50 };

            Dictionary<string, int> dict = Lab9.CombineListsToDictionary(keys, values);
            Dictionary<string, int> expectedDict = new Dictionary<string, int>
            {
                { "hello", 2 },
                { "world", 5 },
                { "comp1500", 10 },
                { "intro", 40 },
                { "to", -11 },
                { "c#", -50 }
            };

            printDictionary(dict);

            Debug.Assert(dict.Count == expectedDict.Count);

            foreach (var keyvaluePair in expectedDict)
            {
                Debug.Assert(keyvaluePair.Value == dict[keyvaluePair.Key]);
            }

            Dictionary<string, int> numerators = new Dictionary<string, int>
            {
                { "a", 53 },
                { "b", -14 },
                { "c", 5 },
                { "d", 235 },
                { "g", 1 },
            };
            Dictionary<string, int> denominators = new Dictionary<string, int>
            {
                { "a", 77 },
                { "b", 235 },
                { "c", -3 },
                { "d", 121 },
                { "e", 8 },
                { "f", -621 },
            };

            Dictionary<string, decimal> result = Lab9.MergeDictionaries(numerators, denominators);
            Dictionary<string, decimal> expectedResult = new Dictionary<string, decimal>
            {
                { "a", 0.6883116883116883116883116883m },
                { "b", 0.0595744680851063829787234043m },
                { "c", 1.6666666666666666666666666667m },
                { "d", 1.9421487603305785123966942149m }
            };

            printDictionary(result);

            Debug.Assert(expectedResult.Count == result.Count);

            foreach (var keyvaluePair in expectedResult)
            {
                Debug.Assert(keyvaluePair.Value == result[keyvaluePair.Key]);
            }
        }

        private static void printDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[ ");

            foreach (var keyvaluepair in dict)
            {
                sb.Append($"{{ {keyvaluepair.Key}, {keyvaluepair.Value} }}, ");
            }

            string s = sb.ToString().Trim().Trim(',');
            Console.WriteLine($"{s} ]");
        }
    }
}
        */
        public static int GetNumberOfSteps(int numDiscs)
        {
            if (numDiscs < 0)
            {
                return -1;
            }

            return (int)Math.Pow(2, numDiscs) - 1;
        }

        public static List<List<int>[]> SolveTowerOfHanoi(int numDiscs)
        {
            List<List<int>[]> snapshots = new List<List<int>[]>();

            if (numDiscs < 1)
            {
                return snapshots;
            }

            List<int>[] pegs = new List<int>[3]
            {
                new List<int>(numDiscs),
                new List<int>(),
                new List<int>()
            };

            for (int i = numDiscs; i >= 1; i--)
            {
                pegs[0].Add(i);
            }

            snapshots.Add(ClonePegs(pegs));
            MoveDiscs(numDiscs, pegs, 0, 2, 1, snapshots);

            return snapshots;
        }

        public static void MoveDiscs(int numDiscs, List<int>[] pegs, int fromPeg, int toPeg, int usingPeg, List<List<int>[]> snapshots)
        {
            if (numDiscs <= 0)
            {
                return;
            }

            MoveDiscs(numDiscs - 1, pegs, fromPeg, usingPeg, toPeg, snapshots);

            pegs[toPeg].Add(pegs[fromPeg][pegs[fromPeg].Count - 1]);
            pegs[fromPeg].RemoveAt(pegs[fromPeg].Count - 1);
            snapshots.Add(ClonePegs(pegs));

            MoveDiscs(numDiscs - 1, pegs, usingPeg, toPeg, fromPeg, snapshots);
        }

        public static List<int>[] ClonePegs(List<int>[] pegs)
        {
            List<int>[] clonedPegs = new List<int>[3]
            {
                new List<int>(pegs[0].Count),
                new List<int>(pegs[1].Count),
                new List<int>(pegs[2].Count)
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < pegs[i].Count; j++)
                {
                    clonedPegs[i].Add(pegs[i][j]);
                }
            }

            return clonedPegs;
        }
    }
}