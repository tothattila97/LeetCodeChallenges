public int RomanToInt(string s) {
        if (s.Length == 0 || s == null)
                return 0;

            var romanMap = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            var sum = romanMap[s[0]];
            for (var i = 1; i < s.Length; i++)
                sum += romanMap[s[i - 1]] < romanMap[s[i]] ? romanMap[s[i]] - 2 * romanMap[s[i - 1]] : romanMap[s[i]];

            return sum;
    }
