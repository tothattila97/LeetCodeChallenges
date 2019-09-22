public void ReverseString(char[] s) {
            int i = 0;
            while (s.Length - 1 - i - i >= 1)
            {
                var temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
                i++;
            }
    }
