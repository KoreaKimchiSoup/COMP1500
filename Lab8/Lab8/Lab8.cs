using System.ComponentModel;
using System.Text;

namespace Lab8
{
    public static class Lab8
    {
        public static string PrettifyListOrNull(string s)
        {
            StringBuilder builder = new StringBuilder(4096);
            string[] tokens1 = s.Split('|');
            int level1 = 0;
            int level2 = 0;
            int level3 = 0;
            int index = 25;
            int alphpbetIndex = 25;
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < tokens1.Length; ++i)
            {
                string[] tokens2 = tokens1[i].Split('_');

                // 첫 번째 레벨 항목
                level1++;
                builder.AppendFormat("{0}) {1}\n", level1, tokens2[0]);

                for (int j = 1; j < tokens2.Length; ++j)
                {
                    string[] tokens3 = tokens2[j].Split('/');

                    // 두 번째 레벨 항목
                    level2++;
                    builder.AppendFormat("    {0}) {1}\n", alphabet[alphpbetIndex % index], tokens3[0]);

                    for (int k = 1; k < tokens3.Length; ++k)
                    {
                        // 세 번째 레벨 항목
                        level3++;
                        builder.AppendFormat("        {0}{1}\n", "- ", tokens3[k]);
                    }

                    alphpbetIndex++;
                }
            }

            return builder.ToString();
        }
    }
}