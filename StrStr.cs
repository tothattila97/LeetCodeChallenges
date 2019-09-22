public int StrStr(string haystack, string needle)
        {

            if (!haystack.Contains(needle))
                return -1;

            return haystack.IndexOf(needle);
        }
