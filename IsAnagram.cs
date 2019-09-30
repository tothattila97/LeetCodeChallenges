 public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
                return false;
        
            char[] sArr; char[] tArr;
            Array.Sort(sArr = s.ToCharArray());
            Array.Sort(tArr = t.ToCharArray());
            s = string.Concat(sArr);
            t = string.Concat(tArr);
            
            // The solution below was slower because of the OrderBy. The Sort was faster for me.
            // However it depends on how many items and how many times should have to sort.
            
            //s = string.Concat(s.OrderBy(x => x));
            //t = string.Concat(t.OrderBy(x => x));

            if (s == t)
                return true;
            return false;
    }
