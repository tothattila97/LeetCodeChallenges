public int HammingWeight(uint n) => Convert.ToString(n,2).Count(x => x == '1');
