public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 == 1)
                return false;
            var openSequence = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    openSequence.Add(s[i]);
                else
                {
                    if (openSequence.Count == 0)
                        return false;
                    var last = openSequence.Last();
                    switch (last)
                    {
                        case '(':
                            if (s[i] == ')')
                                openSequence.RemoveAt(openSequence.Count-1);
                            else
                                return false;
                            break;
                        case '{':
                            if (s[i] == '}')
                                openSequence.RemoveAt(openSequence.Count - 1);
                            else
                                return false;
                            break;
                        case '[':
                            if (s[i] == ']')
                                openSequence.RemoveAt(openSequence.Count - 1);
                            else
                                return false;
                            break;
                        default:
                            break;
                    }
                }
            }
            if (openSequence.Count == 0)
                return true;
            else
                return false;
    }
}
