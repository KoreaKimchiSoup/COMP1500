using System.Text;

namespace Lab8
{
    public static class Lab8
    {
        public static string PrettifyListOrNull(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }

            StringBuilder builder = new StringBuilder(4096);
            string[] tokens1 = s.Split('|');
            int levelOneIndex = 0;
            int alphabetIndex = 1;

            for (int i = 0; i < tokens1.Length; ++i)
            {
                string[] tokens2 = tokens1[i].Split('_');

                levelOneIndex++;
                // builder.AppendFormat("{0}) {1}\n", levelOneIndex, tokens2[0]);
                builder.AppendLine($"{levelOneIndex}) {tokens2[0]}");

                for (int j = 1; j < tokens2.Length; ++j)
                {
                    string[] tokens3 = tokens2[j].Split('/');
                    string alphabet = "";
                    int temp = alphabetIndex;

                    while (temp > 0)
                    {
                        alphabet = (char)((temp - 1) % 26 + 97) + alphabet; // a ~ z, aa ~ zz ... a.. ~ z..
                        temp = (temp - 1) / 26;
                    }

                    // builder.AppendFormat("    {0}) {1}\n", alphabet, tokens3[0]);
                    builder.AppendLine($"    {alphabet}) {tokens3[0]}");

                    for (int k = 1; k < tokens3.Length; ++k)
                    {
                        // builder.AppendFormat("        {0}{1}\n", "- ", tokens3[k]);
                        builder.AppendLine($"        - {tokens3[k]}");
                    }
                    
                    alphabetIndex++;
                }

                alphabetIndex = 1;
            }

            return builder.ToString();
        }
    }
}