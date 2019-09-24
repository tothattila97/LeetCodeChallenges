public string ConvertToTitle(int n) {
       var res = new List<char>();

            uint sum = 0; uint i = 0;
            while (sum < n)
            {
                sum += 26 * (uint)Math.Pow(26, i);
                i++;
            }
            i--;
            while(n != 0)
            {
                var q = n / (int)Math.Pow(26, i);
                if(i == 1 && n - q*26 == 0)
                {
                    res.Add((char)(65 + q - 2));
                    res.Add((char)(65 + 25));
                    n = 0;
                }
                else
                {
                    res.Add((char)(65 + q - 1));
                    n -= q * (int)Math.Pow(26, i);
                    i--;
                }                
            }
            return string.Concat(res);
    }
