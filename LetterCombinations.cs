public IList<string> LetterCombinations(string digits) {
        
        if(digits == "")
            return new List<string>();
        var map = new Dictionary<string, string[]>
            {
                { "2", new string[] { "a", "b", "c" } },
                { "3", new string[] { "d", "e", "f" } },
                { "4", new string[] { "g", "h", "i" } },
                { "5", new string[] { "j", "k", "l" } },
                { "6", new string[] { "m", "n", "o" } },
                { "7", new string[] { "p", "q", "r", "s" } },
                { "8", new string[] { "t", "u", "v" } },
                { "9", new string[] { "w", "x", "y", "z" } }
            };

            var resList = new List<string>();

            var first = map.GetValueOrDefault(digits[0].ToString());
            foreach (var item in first)
                resList.Add(item);

            for (int i = 1; i < digits.Length; i++)
            {
                var tempList = new List<string>();
                var current = map.GetValueOrDefault(digits[i].ToString());
                for (int j = 0; j < current.Length; j++)
                {
                    tempList.AddRange(resList.Select(val => val + current[j]));
                }
                resList.Clear();
                resList.AddRange(tempList);
            }
            return resList;
    }
