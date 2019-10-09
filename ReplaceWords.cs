 // This is not a really efficient solution because is used a lot of LINQ expression
 
 public string ReplaceWords(IList<string> dict, string sentence) {
         var words = sentence.Split(" ");
            
            for (int i = 0; i < words.Length; i++)
            {
                if (dict.Any(x => words[i].StartsWith(x)))
                    words[i] = dict.Where(x => words[i].StartsWith(x)).OrderBy(x => x.Length).First();
            }
            return string.Join(" ", words);
    }
