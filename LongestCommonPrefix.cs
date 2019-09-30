public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
                return "";

            var prefix = "";
            var minStr = strs.Min().ToCharArray();
            var counter = 0;
            for (int i = 0; i < minStr.Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] == minStr[i])
                        counter++;
                }
                if (counter == strs.Length)
                {
                    prefix = string.Concat(prefix, minStr[i]);
                    counter = 0;
                }
                else
                    break;
            }
            return prefix;
    }
