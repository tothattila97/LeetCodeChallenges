public int TitleToNumber(string s)
        {
            var len = s.Length;
            var res = 0;
            for (int i = 0; i < len; i++)
            {
                res += (int)Math.Pow(26, len - 1 - i) * (s[i] - 'A' + 1);
            }
            return res;
        }
