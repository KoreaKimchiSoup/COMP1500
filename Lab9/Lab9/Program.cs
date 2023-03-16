using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
