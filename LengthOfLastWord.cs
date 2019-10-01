public static int LengthOfLastWord(string s)
            => s.Split(" ", StringSplitOptions.RemoveEmptyEntries).LastOrDefault() != null
                    ? s.Split(" ", StringSplitOptions.RemoveEmptyEntries).LastOrDefault().Length : 0;
