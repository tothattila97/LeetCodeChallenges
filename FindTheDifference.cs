public char FindTheDifference(string s, string t){
            var dict = new Dictionary<char, int>();
            foreach (var item in t)
            {
                if (dict.TryGetValue(item, out _))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }
            foreach (var item in s)
            {
                if (dict.TryGetValue(item, out _))
                    dict[item]--;
            }
            return dict.Where(x => x.Value > 0).First().Key;
    }
